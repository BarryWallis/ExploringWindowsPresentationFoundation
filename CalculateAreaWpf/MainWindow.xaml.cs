using System.Windows;

namespace CalculateAreaWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void TriangleAreaButton_Click(object sender, RoutedEventArgs e) => new TriangleAreaWindow().Show();

        private void RectangleAreaButton_Click(object sender, RoutedEventArgs e) => new RectangleAreaWindow().Show();

        private void TrapezoidAreaButton_Click(object sender, RoutedEventArgs e) => new TrapezoidAreaWindow().Show();
    }
}
