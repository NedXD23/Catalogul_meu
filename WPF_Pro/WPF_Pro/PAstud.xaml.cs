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
    /// Interaction logic for PAstud.xaml
    /// </summary>
    public partial class PAstud : Page
    {
        int c;
        PAaddS a;
        PAdels d;
        PaddN n;
        public PAstud(List<Studenti>studenti,int nr_c)
        {
            
            InitializeComponent();
            st.Items.Clear();
            for (int i = 0; i < studenti.Count(); i++)
            {
                st.Items.Add(studenti[i]);
            }
            c = nr_c;
        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            st.Items.Clear();
            using (var ctx = new FacultateaXEntities1())
            {
                var p = ctx.Studentis.SqlQuery("select* from Studenti").ToList();


                for (int i = 0; i < p.Count(); i++)
                {
                    st.Items.Add(p[i]);
                }
            }

        }

        private void ad_p_Click(object sender, RoutedEventArgs e)
        {
            a = null;
            a = new PAaddS(c);
            a.Show();
        }

        private void dl_p_Click(object sender, RoutedEventArgs e)
        {
            d = null;
            d = new PAdels();
            d.Show();

        }

        private void dl_p_Copy_Click(object sender, RoutedEventArgs e)
        {
            n = null;
            n = new PaddN();
            n.Show();
        }

        private void grp_Click(object sender, RoutedEventArgs e)
        {
            Stud.Content = new PAdmin();
        }
    }
}
