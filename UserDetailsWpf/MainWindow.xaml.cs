using System.Windows;
using System.Windows.Input;

namespace UserDetailsWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void NameTextBox_MouseEnter(object sender, MouseEventArgs e) => NameTextBlock.Visibility = Visibility.Visible;

        private void NameTextBox_MouseLeave(object sender, MouseEventArgs e) => NameTextBlock.Visibility = Visibility.Hidden;

        private void BioTextBox_MouseEnter(object sender, MouseEventArgs e) => BioTextBlock.Visibility = Visibility.Visible;

        private void BioTextBox_MouseLeave(object sender, MouseEventArgs e) => BioTextBlock.Visibility = Visibility.Hidden;

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(BioTextBox.Text))
            {
                _ = MessageBox.Show("Please enter both your name and bio", "Uaer Details", MessageBoxButton.OK);
            }
            else
            {
                _ = MessageBox.Show("Data submitted", "Uaer Details", MessageBoxButton.OK);
                NameTextBox.Text = string.Empty;
                BioTextBox.Text = string.Empty;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameTextBox.Text) || !string.IsNullOrWhiteSpace(BioTextBox.Text))
            {
                e.Cancel = MessageBox.Show("Are you sure you want to leave?", "User Details Exiting", MessageBoxButton.YesNo)
                           == MessageBoxResult.No;
            }
        }
    }
}
