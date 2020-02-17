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

namespace wpfAlfabetico
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

        string[] frasi = new string[5];
        int j = 0;
        private void btn_inserisci_Click(object sender, RoutedEventArgs e)
        {
            frasi[j] = txt_inserisci.Text;
            j++;
            btn_inserisci.IsEnabled = true;
            txt_inserisci.Clear();
            txt_inserisci.Focus();
            if(j >= 5)
            {
                btn_inserisci.IsEnabled = false;
            }
        }
    }
}
