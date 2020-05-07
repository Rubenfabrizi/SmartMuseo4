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

namespace SmartMuseo4
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Cmb_Opere.Items.Add("Tokyo");
            Cmb_Opere.Items.Add("armadio");
            Cmb_Opere.Items.Add("opere");
        }

        private void Cmb_Opere_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
