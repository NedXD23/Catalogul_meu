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
    /// Interaction logic for PAdg.xaml
    /// </summary>
    public partial class PAdg : Window
    {
        int nr_g;
        public PAdg()
        {
            InitializeComponent();
            using (var ctx = new FacultateaXEntities1())
            {
                var g = ctx.Grupes.SqlQuery("select* from Grupe").ToList();
                for (int i = 0; i < g.Count(); i++)
                {
                    Grup.Items.Add(g[i]);
                }
                nr_g = g.Count();
            }
        }

        private void k_Click(object sender, RoutedEventArgs e)
        {
            using (var ctx = new FacultateaXEntities1())
            {
                var check = ctx.Database.SqlQuery<int>("select count(*) from Profesor_Grupe where Id_Cont= '" + i1.Text + "'and Id_Grupa= '" + g1.Text + "'").FirstOrDefault();
                if (check == 0)
                {
                    var modify = ctx.Database.ExecuteSqlCommand("insert into Profesor_Grupe (Id_Cont,Id_Grupa) values ('" + i1.Text + "','" + g1.Text + "') ");
                    if (modify != 0)
                    {
                        MessageBox.Show("Grupa a fost adaugata cu succes");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Grupa nu a fost adaugata");
                    }
                }
                else { MessageBox.Show("Grupa a fost deja adaugata"); }
            }

        }

        private void k_Copy_Click(object sender, RoutedEventArgs e)
        {
            i1.Visibility = Visibility.Hidden;
            i2.Visibility = Visibility.Hidden;
            g1.Visibility = Visibility.Hidden;
            g2.Visibility = Visibility.Hidden;
            k.Visibility = Visibility.Hidden;

            n1.Visibility = Visibility.Visible;
            n2.Visibility = Visibility.Visible;
            k2.Visibility = Visibility.Visible;
        }

        private void k2_Click(object sender, RoutedEventArgs e)
        {

            if (n2.Text.Count() != 0 )
            {
                using (var ctx = new FacultateaXEntities1())
                {
                    nr_g++;
                    int l = ctx.Database.ExecuteSqlCommand("insert into Grupe (Id_Grupa,Nume_Grupa) values ('" + nr_g + "','" + n2.Text + "')");
                    if (l != 0)
                    {
                        MessageBox.Show("Grupa a fost adaugata!");
                        n1.Visibility = Visibility.Hidden;
                        n2.Visibility = Visibility.Hidden;
                        k2.Visibility = Visibility.Hidden;

                        i1.Visibility = Visibility.Visible;
                        i2.Visibility = Visibility.Visible;
                        g1.Visibility = Visibility.Visible;
                        g2.Visibility = Visibility.Visible;
                        k.Visibility = Visibility.Visible;


                    }
                    else
                    {
                        MessageBox.Show("Grupa nu  fost adaugata! incercati din nou");
                    }
                }

            }
            else
            {
                MessageBox.Show("Completati toate campurile !");
            }
        }
    }
}
