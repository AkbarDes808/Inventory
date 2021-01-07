using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for BarangKeluar.xaml
    /// </summary>
    public partial class BarangKeluar : Window
    {
        public BarangKeluar()
        {
            InitializeComponent();
        }

        private void Kode_TextChanged(object sender, TextChangedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-E01TKF81;Initial Catalog=db_inventori;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT nama_barang, tglkeluar_barang, jumlah FROM barang_keluar WHERE kodekeluar_barang = @kodekeluar_barang", con);
            cmd.Parameters.AddWithValue("@kodekeluar_barang", Kode.Text);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                Nama.Text = da.GetValue(0).ToString();
                Tanggal.Text = da.GetValue(1).ToString();
                Jumlah.Text = da.GetValue(2).ToString();
            }
            con.Close();
        }

        private void Nama_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Jumlah_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tanggal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
