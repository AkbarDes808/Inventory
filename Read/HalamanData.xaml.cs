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

namespace inventory.Read
{
    /// <summary>
    /// Interaction logic for HalamanData.xaml
    /// </summary>
    public partial class HalamanData : Window
    {
        public HalamanData()
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
            Suppllier supWindow = new Suppllier();
            supWindow.Show();
        }

        private void OnClickAdmin(object sender, RoutedEventArgs e)
        {
            Admin adminWindow = new Admin();
            adminWindow.Show();
        }

        private void OnClickKaryawan(object sender, RoutedEventArgs e)
        {
            Karywan karyawanWindow = new Karywan();
            karyawanWindow.Show();
        }
    }
}
