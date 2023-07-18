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
    /// Interaction logic for PProf_datepers.xaml
    /// </summary>
    public partial class PProf_datepers : Page
    {
        Profesori profesor;
       
        public PProf_datepers(Profesori prof)
        {
            InitializeComponent();
            Nume.Content = prof.Nume;
            Prenume.Content = prof.Prenume;
            Functie.Content = prof.Functie;
            nr_tlf.Content = prof.Numar_telefon;
            email.Content = prof.Email;
            adresa.Content = prof.Adresa;
            profesor = prof;
        }

        private void Welcome_Click(object sender, RoutedEventArgs e)
        {
            // date_pers.Content = null;
            Date.Content = null;
            Date.Content = new PProfesor(profesor.Id_Cont);

           
        }

        private void Date_personale_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Student_Click(object sender, RoutedEventArgs e)
        {
            Date.Content = null;
            Date.Content = new PCauta_st(profesor);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }
    }
}
