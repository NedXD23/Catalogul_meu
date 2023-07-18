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
    /// Interaction logic for PAll.xaml
    /// </summary>
    public partial class PAll : Page
    {
        Profesori pr;
        public PAll(string mat,List<Grupe>grup,Profesori prof)
        {
            InitializeComponent();
            List<CStud> s=new List<CStud>();
            UtilitarScolar ut = new UtilitarScolar();
           
            all.Items.Clear();
            using (var ctx = new FacultateaXEntities1())
            {
                
            
                List<CStud> studenti = ctx.Database.SqlQuery<CStud>("select s.Nume, s.Prenume, g.Nume_Grupa, c.Nume_Materie, c.Nota_Examen, c.Data_Examen, c.Nota_restanta, c.Data_restanta,c.Id_nota from Studenti as s inner join Grupe as g on s.Id_Grupa = g.Id_Grupa inner join Catalog_note as c on s.Id_Cont = c.Id_Cont where c.Nume_Materie = '" + mat + "'").ToList();

                for (int i = 0; i < studenti.Count(); i++)
                {
                    int ok = 0;
                    for (int j = 0; j < grup.Count(); j++)
                        {
                        if (grup[j].Nume_Grupa == studenti[i].Nume_Grupa)
                            ok = 1;
                        }
                    if (ok == 1)
                    {
                        all.Items.Add(studenti[i]);
                        s.Add(studenti[i]);
                        ok = 0;
                    }
                }
                med.Content = ut.calcul_med_grup(s);
                Nr_r.Content = ut.nr_restantieri(s);
                pr = prof;
            }

        }

        private void Welcome_Click(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void Date_personale_Click(object sender, RoutedEventArgs e)
        {
            All.Content = null;
            All.Content = new PProf_datepers(pr);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            All.Visibility = Visibility.Hidden;
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }

        private void Student_Click(object sender, RoutedEventArgs e)
        {
            All.Content = null;
            All.Content = new PCauta_st(pr);
        }
    }
}
