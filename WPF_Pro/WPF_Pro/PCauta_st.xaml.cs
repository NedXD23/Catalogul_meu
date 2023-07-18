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
    /// Interaction logic for PCauta_st.xaml
    /// </summary>
    public partial class PCauta_st : Page
    {

        UtilitarScolar ut = new UtilitarScolar();
        Profesori prof;
        public PCauta_st(Profesori p)
        {
            InitializeComponent();
            prof = p;
        }

        private void cauta_Click(object sender, RoutedEventArgs e)
        {
            
            using (var ctx = new FacultateaXEntities1())
            {
                cat.Items.Clear();
                int Id_Cont;
                
                    Id_Cont = ctx.Database.SqlQuery<int>("Select Id_Cont from Studenti where Nume='" + nume.Text + "'and Prenume='" + prenume.Text + "'").FirstOrDefault();

                    if (Id_Cont != 0)
                    {
                        cauta.Visibility = Visibility.Hidden;

                        restante1.Visibility = Visibility.Visible;
                        Nr_restante.Visibility = Visibility.Visible;

                        Credite.Visibility = Visibility.Visible;
                        Credite_.Visibility = Visibility.Visible;

                        Medie.Visibility = Visibility.Visible;
                        Mediea.Visibility = Visibility.Visible;
                        cat.Visibility = Visibility.Visible;

                        g1.Visibility = Visibility.Visible;
                        g2.Visibility = Visibility.Visible;

                        f1.Visibility = Visibility.Visible;
                        f2.Visibility = Visibility.Visible;

                        s1.Visibility = Visibility.Visible;
                        s2.Visibility = Visibility.Visible;

                        caut2.Visibility = Visibility.Visible;
                        var catalogu = ctx.Catalog_note.SqlQuery("select * from Catalog_note where Id_cont='" + Id_Cont + "'").ToList();
                        var stud = ctx.Studentis.SqlQuery("select * from Studenti where Id_cont='" + Id_Cont + "'").FirstOrDefault();
                        var grupa = ctx.Database.SqlQuery<string>("select Nume_Grupa from Grupe where Id_Grupa='" + stud.Id_Grupa + "'").FirstOrDefault();
                        for (int i = 0; i < catalogu.Count(); i++)
                        {
                            cat.Items.Add(catalogu[i]);

                        }
                        Nr_restante.Content = ut.calcul_restante(Id_Cont);
                        Credite_.Content = ut.Calcul_Credite(Id_Cont);
                        Mediea.Content = ut.calcul_medie(Id_Cont);
                        g2.Content = grupa;
                        f2.Content = stud.Forma_invatamant;
                        s2.Content = stud.Specializare;

                    }
                      else {
                    nume.Clear();
                    prenume.Clear();
                    MessageBox.Show("Studentul Nu Exista!"); 
                      }
                
            }
        }

        private void Date_personale_Click(object sender, RoutedEventArgs e)
        {
            ca.Content = null;
            ca.Content = new PProf_datepers(prof);
        }

        private void Student_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }

        private void Welcome_Click(object sender, RoutedEventArgs e)
        {
            ca.Content = null;
            ca.Content = new PProfesor(prof.Id_Cont);
        }

        private void caut2_Click(object sender, RoutedEventArgs e)
        {
            caut2.Visibility = Visibility.Hidden;

            restante1.Visibility = Visibility.Hidden;
            Nr_restante.Visibility = Visibility.Hidden;

            Credite.Visibility = Visibility.Hidden;
            Credite_.Visibility = Visibility.Hidden;

            Medie.Visibility = Visibility.Hidden;
            Mediea.Visibility = Visibility.Hidden;
            cat.Visibility = Visibility.Hidden;

            g1.Visibility = Visibility.Hidden;
            g2.Visibility = Visibility.Hidden;

            f1.Visibility = Visibility.Hidden;
            f2.Visibility = Visibility.Hidden;

            s1.Visibility = Visibility.Hidden;
            s2.Visibility = Visibility.Hidden;

            cauta.Visibility = Visibility.Visible;
            nume.Clear();
            prenume.Clear();
        }
    }
}
