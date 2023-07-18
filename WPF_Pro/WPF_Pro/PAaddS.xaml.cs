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
    /// Interaction logic for PAaddS.xaml
    /// </summary>
    public partial class PAaddS : Window
    {
        int n;
        public PAaddS(int nr_c)
        {
            InitializeComponent();
            n = nr_c;
        }

        private void k_Click(object sender, RoutedEventArgs e)
        {
            using (var ctx = new FacultateaXEntities1())
            {
                if (u1.Text != null && p1.Text.Count() != 0 && n1.Text.Count() != 0 && pr1.Text.Count() != 0 && nr1.Text.Count() != 0 && e1.Text.Count() != 0 && a1.Text.Count() != 0 && f1.Text.Count() != 0)
                {
                    n++;
                    int noOfRowInserted = ctx.Database.ExecuteSqlCommand("insert into Conturi (Id_Cont,User_nameX,PasswordX,Nivel_acces) values('" + n + "','" + u1.Text + "','" + p1.Text + "',0)");
                    int noOfRowInserted1 = ctx.Database.ExecuteSqlCommand("insert into Studenti(Id_Cont,Nume, Prenume, Numar_telefon, Email, Adresa, Forma_invatamant,Id_Grupa,An_Studiu,Specializare,CNP,Numar_restante) values('" + n + "', '" + n1.Text + "', '" + pr1.Text + "', '" + nr1.Text + "', '" + e1.Text + "', '" + a1.Text + "','" + f1.Text + "','" + Id_g.Text + "','" + an1.Text + "','" + sp1.Text + "','" + c1.Text + "',0)");
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
