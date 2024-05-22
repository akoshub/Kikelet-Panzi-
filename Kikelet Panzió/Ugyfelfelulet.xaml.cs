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

namespace Kikelet_Panzió
{
    /// <summary>
    /// Interaction logic for Ugyfelfelulet.xaml
    /// </summary>
    public partial class Ugyfelfelulet : Window
    {
        List<Ugyfel> ugyfelek = new List<Ugyfel>();
        List<Szoba> szobak = new List<Szoba>();
        
        public Ugyfelfelulet()
        {
            InitializeComponent();
        }

        private void BtnRegiszt_Click(object sender, RoutedEventArgs e)
        {
            string nev = TbxNev.Text;
            DateTime szuletesidatum = DpSzulet.SelectedDate ?? DateTime.MinValue;
            string email = TbxEmail.Text;
            bool vip = ChbxVip.IsChecked ?? false;
            if (!string.IsNullOrEmpty(nev) && szuletesidatum != DateTime.MinValue && !string.IsNullOrEmpty(email))
            {
                Ugyfel ujUgyfel = new Ugyfel(nev, szuletesidatum, email, vip);
            }

        }

        private void ChbxVip_Checked(object sender, RoutedEventArgs e)
        {
            //kedvez = Ar * 0.3;
        }
    }
}
