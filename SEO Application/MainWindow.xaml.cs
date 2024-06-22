using SEO_Application.Pages;
using System.Windows;

namespace SEO_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frame.Navigate(new SearchPage());

        }
    }
}