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
    /// Interaction logic for Suppllier.xaml
    /// </summary>
    public partial class Suppllier : Window
    {
        public Suppllier()
        {
            InitializeComponent();
        }

        private void Kode_TextChanged(object sender, TextChangedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-E01TKF81;Initial Catalog=db_inventori;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT nama_supplier, no_telpon, alamat FROM supplier WHERE kode_supplier = @kode_supplier", con);
            cmd.Parameters.AddWithValue("@kode_supplier", Kode.Text);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                Nama.Text = da.GetValue(0).ToString();
                Telepon.Text = da.GetValue(1).ToString();
                Alamat.Text = da.GetValue(2).ToString();
            }
            con.Close();
        }

        private void Nama_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Alamat_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Telepon_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
