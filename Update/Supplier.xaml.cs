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
    /// Interaction logic for Supplier.xaml
    /// </summary>
    public partial class Supplier : Window
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void KodeSupplier_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NamaSupplier_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NoTelepon_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Alamat_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OnClickInput(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-E01TKF81;Initial Catalog=db_inventori;Integrated Security=True");
                    string UpdateQuery = "UPDATE supplier SET nama_supplier = '" + NamaSupplier.Text + "', no_telpon ='" + NoTelepon.Text + "', alamat ='" + Alamat.Text + "'WHERE kode_supplier=" + int.Parse(KodeSupplier.Text);
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
