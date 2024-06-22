using Controllers;
using Controllers.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace SEO_Application.Pages
{
    /// <summary>
    /// Interaction logic for SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Page
    {
        private SearchForm _searchForm { get; set; }
        private SearchController _searchController;
        public SearchPage()
        {
            InitializeComponent();
            _searchController = _searchController=new SearchController();
            _searchForm = new SearchForm(keyWord: "conveyancing software", url: "www.smokeball.com.au");
            DataContext = _searchForm;
        }
        private void SearchClick(object sender, RoutedEventArgs e)
        {
            var result = _searchController.GetSeoPostition(_searchForm);

            NavigationService.Navigate(new SearchResultsPage(result));
        }

    }
}