using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for PDate_Personale.xaml
    /// </summary>
    public partial class PDate_Personale : Page
    {
        Studenti a;
   
        public PDate_Personale(Studenti s)
        {
            InitializeComponent();
            Nr_t.Content = s.Numar_telefon;
            em.Content = s.Email;
            adre.Content = s.Adresa;
            cnp.Content = s.CNP;

            var poza = new Img();

            using (var imag = new FacultateaXEntities1())
            {
                var pz = imag.Database.SqlQuery<byte[]>("select img from myimages where Id_cont='" + s.Id_Cont + "'").FirstOrDefault();

                if (pz != null)
                {
                    System.Drawing.Image img = poza.byteArrayToImage(pz);

                    BitmapImage bi = new BitmapImage();

                    bi.BeginInit();

                    MemoryStream ms = new MemoryStream();

                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);

                    ms.Seek(0, SeekOrigin.Begin);

                    bi.StreamSource = ms;

                    bi.EndInit();

                    profil.Source = bi;
                }

            }
            a = s;
        }

     
        private void Welcome_Click(object sender, RoutedEventArgs e)
        {
            Date.Content = null;
            Date.Content = new PWelcome(a.Id_Cont);
        }

        private void Date_personale_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Catalog_Click(object sender, RoutedEventArgs e)
        {
            Date.Content = null;
            Date.Content = new PCatalog(a); 
           
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }
    }
}
