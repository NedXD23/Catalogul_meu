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
using System.Windows.Shapes;

namespace WPF_Pro
{
    /// <summary>
    /// Interaction logic for pregister.xaml
    /// </summary>
    public partial class pregister : Window
    {
        int n;
        public pregister(int nr_conturi)
        {
            InitializeComponent();
            n = nr_conturi;
        }

        private void k_Click(object sender, RoutedEventArgs e)
        {
            using (var ctx = new FacultateaXEntities1()) {
                if (u1.Text != null && p1.Text.Count() != 0 && n1.Text.Count() != 0 && pr1.Text.Count() != 0 && nr1.Text.Count() != 0 && e1.Text.Count() != 0 && a1.Text.Count() != 0 && f1.Text.Count() != 0)
                {
                    n++;
                    int noOfRowInserted = ctx.Database.ExecuteSqlCommand("insert into Conturi (Id_Cont,User_nameX,PasswordX,Nivel_acces) values('" + n + "','" + u1.Text + "','" + p1.Text + "',1)");
                    int noOfRowInserted1 = ctx.Database.ExecuteSqlCommand("insert into Profesori(Id_Cont,Nume, Prenume, Numar_telefon, Email, Adresa, Functie) values('" + n + "', '" + n1.Text + "', '" + pr1.Text + "', '" + nr1.Text + "', '" + e1.Text + "', '" + a1.Text + "','" + f1.Text + "')");
                    MessageBox.Show("Inregistrat cu succes!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Completati Toate Camputile!");
                }
            }
        }
    }
}
