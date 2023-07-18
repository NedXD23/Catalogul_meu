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
    /// Interaction logic for PAdmin.xaml
    /// </summary>
    public partial class PAdmin : Page
    {       List<Conturi> c;
            List<Studenti> s;
            List<Profesori> p;
            List<Grupe> g;
            PAstud ss;
            PAprof pp;
        public PAdmin()
        {
           
            InitializeComponent();
            using (var ctx=new FacultateaXEntities1())
            {
                c = ctx.Conturis.SqlQuery("select * from Conturi").ToList();
                s = ctx.Studentis.SqlQuery("select * from Studenti").ToList();
                p = ctx.Profesoris.SqlQuery("select* from Profesori").ToList();
                g = ctx.Grupes.SqlQuery("select* from Grupe").ToList();

                c1.Content = c.Count();
                s1.Content = s.Count();
                p1.Content = p.Count();
                g1.Content = c.Count();
                


            }
        }

        private void prof_Click(object sender, RoutedEventArgs e)
        {
           
            Adm.Content = new PAprof(p,c.Count());
            
           
        }

        private void std_Click(object sender, RoutedEventArgs e)
        {
            Adm.Content = null;
            Adm.Content = new PAstud(s, c.Count);
        }

      
    }
}
