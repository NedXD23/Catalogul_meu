using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Pro
{
    /// <summary>
    /// Interaction logic for PProfesor.xaml
    /// </summary>
    public partial class PProfesor : Page
    {
        Profesori prof;
        List<Grupe> Grup;
        List<Materii> Materiia;
        PProf_datepers a;
        PGrupe g;
        PAll al;
        PCauta_st caut;
        public PProfesor(int id)
        {
            InitializeComponent();
            using (var ctx = new FacultateaXEntities1())
            {
               
              
                var Profesor = ctx.Profesoris.SqlQuery("select * from Profesori where Id_Cont ='" + id+ "'").FirstOrDefault();
                var Grupa = ctx.Grupes.SqlQuery("select *from Profesori as p inner join Profesor_Grupe as pg on p.Id_Cont = pg.Id_Cont inner join Grupe as g on g.Id_Grupa = pg.Id_Grupa where p.Id_Cont ='"+id+"'").ToList();
                var Materiile = ctx.Materiis.SqlQuery("select * from Profesori as p inner join Profesori_Materii as pm on p.Id_Cont = pm.Id_Cont inner join Materii as m on m.Id_Materie = pm.Id_Materie where p.Id_Cont ='" + id + "'").ToList();
                Nume.Content = Profesor.Nume;
                Prenume.Content = Profesor.Prenume;
                Functie.Content = Profesor.Functie;
               for(int i=0;i<Grupa.Count();i++)
                {
                    Grupele.Items.Add(Grupa[i]);
                }
                for (int i = 0; i < Materiile.Count(); i++)
                {
                    Materii.Items.Add(Materiile[i]);
                }
                prof = Profesor;
                Materiia = Materiile;
                Grup = Grupa;
                a = new PProf_datepers(prof);
                caut = new PCauta_st(prof);
            }
            
         
        }

        private void Date_personale_Click(object sender, RoutedEventArgs e)
        {
            Profu.Content = null;
            Profu.Content = a.Content;
        }

        private void Student_Click(object sender, RoutedEventArgs e)
        {
            Profu.Content = null;
            Profu.Content = caut.Content;
        }

        private void Grupele_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            if(dg.SelectedCells!=null && dg.SelectedCells.Count==1)
            {
                var cell = dg.SelectedCells[0];
                var row = dg.ItemContainerGenerator.ContainerFromItem(cell.Item) as DataGridRow;
                if(row!=null && row.IsSelected)
               {
                    int a = row.GetIndex();
                    string x = Grup[a].Nume_Grupa;
                     g= new PGrupe(Materiia, x,prof);

                    Profu.Content = g;

                }
            }
        }

        private void Materii_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            if (dg.SelectedCells != null && dg.SelectedCells.Count == 1)
            {
                var cell = dg.SelectedCells[0];
                var row = dg.ItemContainerGenerator.ContainerFromItem(cell.Item) as DataGridRow;
                if (row != null && row.IsSelected)
                {
                    int a = row.GetIndex();
                    string mat = Materiia[a].Denumire;
                    al = new PAll(mat,Grup,prof);

                    Profu.Content = al;

                }
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {

            Profu.Visibility = Visibility.Hidden;
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }
    }
}
