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
    /// Interaction logic for PAprof.xaml
    /// </summary>
    public partial class PAprof : Page
    {
        pregister reg;
        Ppdel del;
        PAdmat mat;
        PAdg gp;
        PAdmin ad;
        int c;
        public PAprof(List<Profesori> prof,int nr_c)
        {
            InitializeComponent();
            pro.Items.Clear();
            for(int i=0;i<prof.Count();i++)
            {
                pro.Items.Add(prof[i]);
            }
            c = nr_c;
            
        }

        private void ad_p_Click(object sender, RoutedEventArgs e)
        {
            reg = null;
            reg=new pregister(c);
            reg.Show();
        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            pro.Items.Clear();
            using (var ctx = new FacultateaXEntities1())
            {
                var p = ctx.Profesoris.SqlQuery("select* from Profesori").ToList();


                for (int i = 0; i <p.Count();i++)
                {
                    pro.Items.Add(p[i]);
                }
             }
        }

        private void grp_Click(object sender, RoutedEventArgs e)
        {
            PAdm.Content = null;
            ad = new PAdmin();
            PAdm.Content = ad.Content;
           

        }

        private void dl_p_Click(object sender, RoutedEventArgs e)
        {
            del = null;
            del = new Ppdel();
            del.Show();
        }

        private void dl_p_Copy_Click(object sender, RoutedEventArgs e)
        {
            mat = null;
            mat = new PAdmat();
            mat.Show();
        }

        private void dl_p_Copy1_Click(object sender, RoutedEventArgs e)
        {
            gp = null;
            gp = new PAdg();
            gp.Show();
        }
    }
}
