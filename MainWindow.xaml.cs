using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using LanguageExt.ClassInstances.Pred;
using Microsoft.Azure.Amqp.Framing;
using inventory.Read;
using inventory.Delete;
using inventory.Update;

namespace inventory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClickBarang(object sender, RoutedEventArgs e)
        {
            HalananUtama barangWindow = new HalananUtama();
            barangWindow.Show();
        }

        private void OnClickLihat(object sender, RoutedEventArgs e)
        {
            HalamanData dataWindow = new HalamanData();
            dataWindow.Show();
        }

        private void OnClickHapus(object sender, RoutedEventArgs e)
        {
            Hapus hapusWindow = new Hapus();
            hapusWindow.Show();
        }

        private void OnClickUpdate(object sender, RoutedEventArgs e)
        {
            HalamanUtama halamanWindow = new HalamanUtama();
            halamanWindow.Show();
        }
    }   
}
