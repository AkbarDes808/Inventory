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

namespace inventory.Update
{
    /// <summary>
    /// Interaction logic for Barang.xaml
    /// </summary>
    public partial class Barang : Window
    {
        public Barang()
        {
            InitializeComponent();
        }

        private void Kode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Nama_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Berat_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void kadaluarsa_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Jumlah_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UpdateOnClick(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-E01TKF81;Initial Catalog=db_inventori;Integrated Security=True");
                    string UpdateQuery = "UPDATE barang SET nama_barang = '"+Nama.Text+"', berat_barang ='"+Berat.Text+"', kadaluarsa='"+kadaluarsa.Text+ "', jumlah='" + Jumlah.Text + "'WHERE kode_barang=" +int.Parse(Kode.Text);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(UpdateQuery, con);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Berhasil Diupdate"); 
                    }
                    else
                    {
                        MessageBox.Show("Gagal Diupdate");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
