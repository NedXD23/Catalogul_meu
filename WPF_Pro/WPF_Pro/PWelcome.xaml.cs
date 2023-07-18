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
    /// Interaction logic for PWelcome.xaml
    /// </summary>
   
    public partial class PWelcome : Page
    {
         Studenti stud;
         PDate_Personale Pdate;
         PCatalog Pcat;
        public PWelcome(int id_c)
        {
            InitializeComponent();
            using (var ctx = new FacultateaXEntities1())
            {
              
               
                var Student = ctx.Studentis.SqlQuery("select * from Studenti where Id_Cont ='" + id_c + "'").FirstOrDefault();
                var Grupa = ctx.Database.SqlQuery<string>("select Nume_Grupa from Grupe where Id_Grupa='" + Student.Id_Grupa + "'").FirstOrDefault();
                Nume.Content = Student.Nume;
                Prenume.Content = Student.Prenume;
       
                Specializare1.Content = Student.Specializare;
                Forma1.Content = Student.Forma_invatamant;
                An1.Content = Student.An_Studiu;
                Grupa_l.Content = Grupa.ToString();
                UtilitarScolar util = new UtilitarScolar();
                Credite_.Content = util.Calcul_Credite(id_c);
                Nr_restante.Content = util.calcul_restante(id_c);
                Mediea.Content = util.calcul_medie(id_c);

                stud = Student;
            }
            Pdate = new PDate_Personale(stud);
            Pcat = new PCatalog(stud);
        }
      
        private void Date_personale_Click(object sender, RoutedEventArgs e)
        {
         
            Wel.Content = Pdate.Content;
        }

        private void Wel_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Catalog_Click(object sender, RoutedEventArgs e)
        {
            Wel.Content = null;
            Wel.Content = Pcat.Content;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Wel.Visibility = Visibility.Hidden;
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();

        }
    }
}
