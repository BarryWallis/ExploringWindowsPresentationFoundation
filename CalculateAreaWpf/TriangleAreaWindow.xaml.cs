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

namespace CalculateAreaWpf
{
    /// <summary>
    /// Interaction logic for TriangleAreaWindow.xaml
    /// </summary>
    public partial class TriangleAreaWindow : Window
    {
        public TriangleAreaWindow() => InitializeComponent();

        private void CalculateAreaButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AreaTextBlock.Text = (Convert.ToDouble(BaseTextBox.Text) * Convert.ToDouble(HeightTextBox.Text) / 2.0D).ToString();
            }
            catch (Exception ex) when (ex is FormatException or InvalidCastException or OverflowException)
            {
                _ = MessageBox.Show(ex.Message, "Conversion Error");
            }
        }
    }
}
