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
    /// Interaction logic for PaddN.xaml
    /// </summary>
    public partial class PaddN : Window
    {
        public PaddN()
        {
            InitializeComponent();
            InitializeComponent();
            using (var ctx = new FacultateaXEntities1())
            {
                var g = ctx.Materiis.SqlQuery("select* from Materii").ToList();
                for (int i = 0; i < g.Count(); i++)
                {
                    mat.Items.Add(g[i]);
                }

            }
        }

        private void k_Click(object sender, RoutedEventArgs e)
        {
            using (var ctx = new FacultateaXEntities1())
            {
            
                    var modify = ctx.Database.ExecuteSqlCommand("insert into Catalog_Note (Id_Cont,Nume_Materie,Nota_Examen,Data_Examen,Nota_restanta,Data_Restanta,Nr_credite) values ('" + i1.Text + "','" + g1.Text + "','" + n1.Text + "','" + d1.Text + "','" + n2.Text + "','" + d2.Text + "','" + c1.Text + "') ");
                    if (modify != 0)
                    {
                        MessageBox.Show("Nota a fost adaugata cu succes");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nota nu a fost adaugata");
                    }
               
            }

        }
    }
}
