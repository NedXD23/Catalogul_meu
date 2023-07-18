using SimpleInjector;
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
    /// Interaction logic for PGrupe.xaml
    /// </summary>
    public partial class PGrupe : Page
    {
        string grupu;
        List<CStud> stud;
        int id_m;
        int id_s;
        UtilitarScolar util;
        Profesori p;
        public PGrupe(List<Materii> materii,string grupul,Profesori profu)
        {
            InitializeComponent();
            for (int i = 0; i < materii.Count(); i++) {
                combo.Items.Add(materii[i].Denumire);
                    }
            grupu = grupul;
            util = new UtilitarScolar();
            p = profu;
        }

        private void Date_personale_Click(object sender, RoutedEventArgs e)
        {
            Grupp.Content = null;
            Grupp.Content = new PProf_datepers(p);
        }

        private void Welcome_Click(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void Student_Click(object sender, RoutedEventArgs e)
        {
            Grupp.Content = null;
            Grupp.Content = new PCauta_st(p);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Grupp.Visibility = Visibility.Hidden;
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }

        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Medie_Grupa.Visibility = Visibility.Visible;
            Med.Visibility = Visibility.Visible;
            r1.Visibility = Visibility.Visible;
            r2.Visibility = Visibility.Visible;
            Grupa.Items.Clear();
            using (var ctx = new FacultateaXEntities1()) {
                string x = combo.SelectedItem.ToString();
               
                List<CStud> studenti = ctx.Database.SqlQuery<CStud>("select s.Nume, s.Prenume, g.Nume_Grupa, c.Nume_Materie, c.Nota_Examen, c.Data_Examen, c.Nota_restanta, c.Data_restanta,c.Id_nota from Studenti as s inner join Grupe as g on s.Id_Grupa = g.Id_Grupa inner join Catalog_note as c on s.Id_Cont = c.Id_Cont where c.Nume_Materie = '" + x + "' and g.Nume_Grupa = '" + grupu + "'").ToList();

                for (int i = 0; i <studenti.Count();i++)
                    Grupa.Items.Add(studenti[i]);
                stud = studenti;
            }

            Med.Content = util.calcul_med_grup(stud);
            r2.Content = util.nr_restantieri(stud);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            
            using(var ctx=new FacultateaXEntities1())
            {
                string not1, not2;
                not1 = Nota1.Text;
                not2 = Nota2.Text;
                string dat1, dat2;
                dat1 = Data1.Text;
                dat2 = Data2.Text;
                stud[id_s].Data_Examen = dat1;
                stud[id_s].Data_restanta = dat2;
                stud[id_s].Nota_Examen = System.Convert.ToInt32(not1);
                stud[id_s].Nota_restanta = System.Convert.ToInt32(not2);
                int noOfRowUpdate=ctx.Database.ExecuteSqlCommand(" update Catalog_note set Nota_Examen = '"+not1+"',Data_Examen ='"+dat1+"', Nota_restanta = '"+not2+"', Data_restanta ='"+dat2+"' where Id_nota = '"+id_m+"'");
            }

            Med.Content=util.calcul_med_grup(stud);
            r2.Content = util.nr_restantieri(stud);
        }

        private void Grupa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            r1.Visibility = Visibility.Hidden;
            r2.Visibility = Visibility.Hidden;
            Medie_Grupa.Visibility = Visibility.Hidden;
            Med.Visibility = Visibility.Hidden;
            Save.Visibility = Visibility.Visible;
            Nota1.Visibility = Visibility.Visible;
            Nota2.Visibility = Visibility.Visible;
            Data1.Visibility = Visibility.Visible;
            Data2.Visibility = Visibility.Visible;
            N1.Visibility = Visibility.Visible;
            N2.Visibility = Visibility.Visible;
            D1.Visibility = Visibility.Visible;
            D2.Visibility = Visibility.Visible;
            Refresh.Visibility = Visibility.Visible;
      
            DataGrid dg = sender as DataGrid;
            if (dg.SelectedCells != null)
            {
                var cell = dg.SelectedCells[0];
                var row = dg.ItemContainerGenerator.ContainerFromItem(cell.Item) as DataGridRow;
                if (row != null && row.IsSelected)
                {
                    int a = row.GetIndex();
                    Nota1.Text = stud[a].Nota_Examen.ToString();
                    Nota2.Text = stud[a].Nota_restanta.ToString();
                    Data1.Text = stud[a].Data_Examen;
                    Data2.Text = stud[a].Data_restanta;
                    id_m = stud[a].Id_nota;
                    id_s = a;
                }
            }

        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            Grupa.Items.Clear();
            for (int i = 0; i < stud.Count(); i++)
                Grupa.Items.Add(stud[i]);
            Save.Visibility = Visibility.Hidden;
            Nota1.Visibility = Visibility.Hidden;
            Nota2.Visibility = Visibility.Hidden;
            Data1.Visibility = Visibility.Hidden;
            Data2.Visibility = Visibility.Hidden;
            N1.Visibility = Visibility.Hidden;
            N2.Visibility = Visibility.Hidden;
            D1.Visibility = Visibility.Hidden;
            D2.Visibility = Visibility.Hidden;
            Refresh.Visibility = Visibility.Hidden;
            Med.Visibility = Visibility.Visible;
            Medie_Grupa.Visibility = Visibility.Visible;
            r1.Visibility = Visibility.Visible;
            r2.Visibility = Visibility.Visible;
        }
    }
}
