using System.Windows;

namespace CalculateAreaWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void TriangleAreaButton_Click(object sender, RoutedEventArgs e) => _ = MessageBox.Show("Triangle Area buttton clicked");

        private void RectangleAreaButton_Click(object sender, RoutedEventArgs e) => _ = MessageBox.Show("Rectangle Area buttton clicked");

        private void TrapezoidAreaButton_Click(object sender, RoutedEventArgs e) => _ = MessageBox.Show("Trapezoid Area buttton clicked");
    }
}
