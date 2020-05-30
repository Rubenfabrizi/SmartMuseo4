using SmartMuseo4.Model;
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
using System.Windows.Shapes;

namespace SmartMuseo4
{
    /// <summary>
    /// Logica di interazione per Tokyo.xaml
    /// </summary>
    public partial class Tokyo : Window
    {
        public Tokyo()
        {
            InitializeComponent();
        }

        public void DescrizioneOpere()
        {
            Opera1 o = new Opera1();

            o.DescrizioneOpera = "Descrizione dell'opera";
            Lbl_opera1.Content = o.DescrizioneOpera;
        }
    }
}
