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

namespace Tema2_CaracteresLimitados
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

        private void Contador()
        {
            int c = Texto_TextBox.Text.Replace(Environment.NewLine,string.Empty).Length;
            string cont = c.ToString();
            contador_TextBlock.Text = cont + "/140";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Contador();
        }
    }
}
