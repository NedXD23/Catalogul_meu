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
    /// Interaction logic for PCatalog.xaml
    /// </summary>
    public partial class PCatalog : Page
    {
        Studenti a;
        public PCatalog(Studenti b)
        {
            InitializeComponent();
            using (var ctx = new FacultateaXEntities1())
            {
                var Student = ctx.Studentis.SqlQuery("select * from Studenti where Id_Cont ='" + b.Id_Cont + "'").FirstOrDefault();
                var catalogu = ctx.Catalog_note.SqlQuery("select * from Catalog_note where Id_cont='" + b.Id_Cont + "'").ToList();
                for (int i = 0; i < catalogu.Count(); i++)
                {
                    cat.Items.Add(catalogu[i]);
                   
                }
                a = Student;
            }
        }

       
        private void Date_personale_Click(object sender, RoutedEventArgs e)
        {
            Catalogu.Content = null;
            Catalogu.Content = new PDate_Personale(a);
                        
        }

     
        private void Welcome_Click(object sender, RoutedEventArgs e)
        {
            Catalogu.Content =null;
            Catalogu.Content = new PWelcome(a.Id_Cont);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }
    }
}
