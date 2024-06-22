using Controllers;
using SEO_Application.Pages;
using System.Windows;

namespace SEO_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SearchController _searchController;
        public MainWindow()
        {
            
            InitializeComponent();
            _searchController = new SearchController(new SerpAPILibrary.SerpAPI());
            frame.Navigate(new SearchPage(_searchController));
        }
    }
}