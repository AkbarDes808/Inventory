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

namespace inventory.Delete
{
    /// <summary>
    /// Interaction logic for BarangMasuk.xaml
    /// </summary>
    public partial class BarangMasuk : Window
    {
        public BarangMasuk()
        {
            InitializeComponent();
        }

        private void OnClickHapus(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-E01TKF81;Initial Catalog=db_inventori;Integrated Security=True");
                    string deleteQuery = "DELETE FROM barang_masuk WHERE kodemasuk_barang = " + Kode.Text;
                    con.Open();
                    SqlCommand cmd = new SqlCommand(deleteQuery, con);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Dihapus");
                    }
                    else
                    {
                        MessageBox.Show("Gagal Terhapus");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Kode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
