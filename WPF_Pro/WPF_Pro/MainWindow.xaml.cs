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
using System.Data.SqlClient;
using System.Data;

namespace WPF_Pro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (var ctx = new FacultateaXEntities1())
            {
               
                int login=ctx.Database.SqlQuery<int>("Select count(*) from Conturi where User_nameX = '" + usr.Text + "' and  PasswordX = '" + pass.Password + "'").FirstOrDefault();


                if (login.Equals(1))
                {
                    var cont = ctx.Conturis.SqlQuery("Select * from Conturi where User_nameX = '" + usr.Text + "' and  PasswordX = '" + pass.Password + "'").FirstOrDefault();
                    if (cont.Nivel_acces == 0)
                    {

                        MessageBox.Show("Bun Venit Student!");

                        MainWin.Content = new PWelcome(cont.Id_Cont);

                    } else if (cont.Nivel_acces == 1)
                    {

                        MessageBox.Show("Bun Venit Domnule Profesor!");
                        MainWin.Content = new PProfesor(cont.Id_Cont);
                    }
                    else if (cont.Nivel_acces == 2)
                    {
                        MainWin.Content = new PAdmin();
                    }
                    else
                    {
                        MessageBox.Show("Error Please contact Staff!");
                        this.Close();
                    }
                    //else eroare

                }

                else
                {
                 
                    MessageBox.Show("Please check Password!");

                }
            }
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       
    }
}
