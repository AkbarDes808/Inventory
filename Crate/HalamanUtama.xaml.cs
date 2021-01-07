using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace inventory
{
    /// <summary>
    /// Interaction logic for HalananUtama.xaml
    /// </summary>
    public partial class HalananUtama : Window
    {
        public HalananUtama()
        {
            InitializeComponent();
        }

        private void OnClickBarang(object sender, RoutedEventArgs e)
        {
            Window1 barangWindow = new Window1();
            barangWindow.Show();
        }
        private void OnClickMasuk(object sender, RoutedEventArgs e)
        {
            BarangMasuk barangmasuk = new BarangMasuk();
            barangmasuk.Show();
        }

        private void OnClickKeluar(object sender, RoutedEventArgs e)
        {
            BarangKeluar barangkeluar = new BarangKeluar();
            barangkeluar.Show();
        }

        private void OnClickSup(object sender, RoutedEventArgs e)
        {
            Supplier supplier = new Supplier();
            supplier.Show();
        }

        private void OnClickAdmin(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
        }

        private void OnClickKaryawan(object sender, RoutedEventArgs e)
        {
            Karyawan karyawn = new Karyawan();
            karyawn.Show();
        }
    }
}

