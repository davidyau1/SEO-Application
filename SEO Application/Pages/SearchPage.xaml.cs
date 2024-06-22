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
        private SearchController _c;
        private SearchForm _searchForm { get; set; }
        public SearchPage(SearchController searchController)
        {
            InitializeComponent();
            _c = searchController;
            _searchForm = new SearchForm(keyWord: "conveyancing software", url: "www.smokeball.com.au");
            DataContext = _searchForm;
        }
        private void SearchClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SearchResultsPage(_c, _searchForm));
        }



    }
}