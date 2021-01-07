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
using System.Data.SqlClient;

namespace inventory.Read
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            

        }

        private void Kode_TextChanged(object sender, TextChangedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-E01TKF81;Initial Catalog=db_inventori;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT nama_admin, no_telponadmin FROM administrator WHERE kode_admin = @kode_admin", con);
            cmd.Parameters.AddWithValue("@kode_admin", Kode.Text);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                Nama.Text = da.GetValue(0).ToString();
                Hp.Text = da.GetValue(1).ToString();
            }
            con.Close();
        }

        private void Nama_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Hp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
