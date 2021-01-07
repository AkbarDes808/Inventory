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

namespace inventory.Update
{
    /// <summary>
    /// Interaction logic for HalamanUtama.xaml
    /// </summary>
    public partial class HalamanUtama : Window
    {
        public HalamanUtama()
        {
            InitializeComponent();
        }

        private void OnClickBarang(object sender, RoutedEventArgs e)
        {
            Barang barangWindow = new Barang();
            barangWindow.Show();
        }

        private void OnClickMasuk(object sender, RoutedEventArgs e)
        {
            BarangMasuk masukWindow = new BarangMasuk();
            masukWindow.Show();
        }

        private void OnClickKeluar(object sender, RoutedEventArgs e)
        {
            BarangKeluar keluarWindow = new BarangKeluar();
            keluarWindow.Show();
        }

        private void OnClickSup(object sender, RoutedEventArgs e)
        {
            Supplier supWindow = new Supplier();
            supWindow.Show();
        }

        private void OnClickAdmin(object sender, RoutedEventArgs e)
        {
            Admin adminWindow = new Admin();
            adminWindow.Show();
        }

        private void OnClickKaryawan(object sender, RoutedEventArgs e)
        {
            Karyawan karWindow = new Karyawan();
            karWindow.Show();
        }
    }
}
