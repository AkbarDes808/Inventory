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
    /// Interaction logic for Karyawan.xaml
    /// </summary>
    public partial class Karyawan : Window
    {
        public Karyawan()
        {
            InitializeComponent();
        }

        private void KodeKaryawan_TextChanged(object sender, TextChangedEventArgs e)
        {

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

        private void OnClickInput(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-E01TKF81;Initial Catalog=db_inventori;Integrated Security=True");
                    string UpdateQuery = "UPDATE karyawan SET nama_karyawan = '" + Nama.Text + "', no_telponkaryawan ='" + Telepon.Text + "', sift_karyawan ='" + Sift.Text + "'WHERE kode_karyawan=" + int.Parse(KodeKaryawan.Text);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(UpdateQuery, con);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Berhasil Diupdate");
                    }
                    else
                    {
                        MessageBox.Show("Gagal Terupdate");
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
