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
    /// Interaction logic for Karywan.xaml
    /// </summary>
    public partial class Karywan : Window
    {
        public Karywan()
        {
            InitializeComponent();
        }

        private void Kode_TextChanged(object sender, TextChangedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-E01TKF81;Initial Catalog=db_inventori;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT nama_karyawan, no_telponkaryawan, sift_karyawan FROM karyawan WHERE kode_karyawan = @kode_karyawan", con);
            cmd.Parameters.AddWithValue("@kode_karyawan", Kode.Text);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                Nama.Text = da.GetValue(0).ToString();
                Telepon.Text = da.GetValue(1).ToString();
                Sift.Text = da.GetValue(2).ToString();                
            }
            con.Close();
        }

        private void Nama_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Telepon_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Sift_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
