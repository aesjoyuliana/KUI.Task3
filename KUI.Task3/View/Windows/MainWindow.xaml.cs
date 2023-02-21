using KUI.Task3.Core;
using KUI.Task3.View.Pages;
using System.Windows;

namespace KUI.Task3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Test.TestFrame = MainFrame;
            MainFrame.Navigate(new MainPage());
        }
    }
}
