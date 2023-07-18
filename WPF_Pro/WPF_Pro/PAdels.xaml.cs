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
    /// Interaction logic for PAdels.xaml
    /// </summary>
    public partial class PAdels : Window
    {
        public PAdels()
        {
            InitializeComponent();
        }

        private void k_Click(object sender, RoutedEventArgs e)
        {
            if (i1.Text.Count() != 0)
            {
                using (var ctx = new FacultateaXEntities1())
                {
                    var m = ctx.Database.ExecuteSqlCommand("DELETE  from Catalog_note where Id_Cont = '" + i1.Text + "'");
                    var s = ctx.Database.ExecuteSqlCommand("delete from Studenti where Id_Cont = '" + i1.Text + "'");
                    var c = ctx.Database.ExecuteSqlCommand("delete from Conturi where Id_Cont = '" + i1.Text + "'");


                    if (s != 0 && c != 0)
                    {
                        MessageBox.Show("Stergerea a fost realizat!");
                        this.Close();
                        this.Content = null;
                    }
                }

            }
            else
            {
                MessageBox.Show("Introduceti Id!");
            }
        }
    }
}
