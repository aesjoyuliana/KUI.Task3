using KUI.Task3.Core;
using System.Windows;
using System.Windows.Controls;

namespace KUI.Task3.View.Pages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            Test.TestFrame?.Navigate(new Task1());
        }
    }
}
