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
    /// Interaction logic for Ppdel.xaml
    /// </summary>
    public partial class Ppdel : Window
    {
        public Ppdel()
        {
            InitializeComponent();
        }

        private void k_Click(object sender, RoutedEventArgs e)
        {
            if (i1.Text.Count() != 0)
            {
                using (var ctx=new FacultateaXEntities1())
                {   
                    var m = ctx.Database.ExecuteSqlCommand("DELETE  from Profesori_Materii where Id_Cont = '" + i1.Text + "'");
                    var g = ctx.Database.ExecuteSqlCommand("delete from Profesor_Grupe where Id_Cont =  '" + i1.Text + "'");
                    var p = ctx.Database.ExecuteSqlCommand("delete from Profesori where Id_Cont = '" + i1.Text + "'");
                    var c = ctx.Database.ExecuteSqlCommand("delete from Conturi where Id_Cont = '" + i1.Text + "'");
                  

                    if(p!=0 && c!=0)
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
