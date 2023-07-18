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
    /// Interaction logic for PAdmat.xaml
    /// </summary>
    public partial class PAdmat : Window
    {
        int nr_mat;
        public PAdmat()
        {
            InitializeComponent();
            using (var ctx = new FacultateaXEntities1())
            {
                var m = ctx.Materiis.SqlQuery("select* from Materii").ToList();
                for (int i = 0; i < m.Count(); i++)
                {
                    Materii.Items.Add(m[i]);
                }
                nr_mat = m.Count();
            }
        }

        private void k_Click(object sender, RoutedEventArgs e)
        {
            using (var ctx = new FacultateaXEntities1())
            {
                var check = ctx.Database.SqlQuery<int>("select count(*) from Profesori_Materii where Id_Cont= '" + i1.Text + "'and Id_Materie= '" + m1.Text + "'").FirstOrDefault();
                if (check == 0)
                {
                    var modify = ctx.Database.ExecuteSqlCommand("insert into Profesori_Materii (Id_Cont,Id_Materie) values ('" + i1.Text + "','" + m1.Text + "') ");
                    if (modify != 0)
                    {
                        MessageBox.Show("Materia a fost adaugata cu succes");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Materia nu a fost adaugata");
                    }
                }
                else { MessageBox.Show("Materia a fost deja adaugata"); }
            }
        }

        private void k_Copy_Click(object sender, RoutedEventArgs e)
        {
            i1.Visibility = Visibility.Hidden;
            i2.Visibility = Visibility.Hidden;
            m1.Visibility = Visibility.Hidden;
            m2.Visibility = Visibility.Hidden;
            k.Visibility = Visibility.Hidden;

            d1.Visibility = Visibility.Visible;
            d2.Visibility = Visibility.Visible;
            n1.Visibility = Visibility.Visible;
            n2.Visibility = Visibility.Visible;
            k2.Visibility = Visibility.Visible;
            
         
        }

        private void k2_Click(object sender, RoutedEventArgs e)
        {
            if(d2.Text.Count()!=0 && n2.Text.Count()!=0)
            {
                using (var ctx=new FacultateaXEntities1())
                {
                    nr_mat++;
                    int l = ctx.Database.ExecuteSqlCommand("insert into Materii (Id_Materie,Denumire,Nr_credite) values ('" + nr_mat + "','" + d2.Text + "','" + n2.Text + "')");
                    if(l!=0)
                    {
                        MessageBox.Show("Materia a fost adaugata!");
                        d1.Visibility = Visibility.Hidden;
                        d2.Visibility = Visibility.Hidden;
                        n1.Visibility = Visibility.Hidden;
                        n2.Visibility = Visibility.Hidden;
                        k2.Visibility = Visibility.Hidden;

                        i1.Visibility = Visibility.Visible;
                        i2.Visibility = Visibility.Visible;
                        m1.Visibility = Visibility.Visible;
                        m2.Visibility = Visibility.Visible;
                        k.Visibility = Visibility.Visible;
               

                    }
                    else
                    {
                        MessageBox.Show("Materia nu  fost adaugata! incercati din nou");
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

