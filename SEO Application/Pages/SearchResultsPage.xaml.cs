using System.Windows;
using System.Windows.Controls;
using Controllers;
using Controllers.Models;
namespace SEO_Application.Pages
{
    /// <summary>
    /// Interaction logic for SearchResultsPage.xaml
    /// </summary>
    public partial class SearchResultsPage : Page
    {
        private SearchForm _searchForm;
        private SearchController _searchController;
        private ResultForm _resultForm;
        public SearchResultsPage(SearchForm searchForm)
        {
            _searchForm = searchForm;
            _searchController = new SearchController();
            _resultForm = new ResultForm(searchForm);
            InitializeComponent();
            DataContext = _resultForm;
            LoadSearchData();
        }


        private async Task LoadSearchData()
        {
            var result = _searchController.GetSeoPostition(_searchForm);
            if (result == null||string.IsNullOrWhiteSpace(result.Result))
            {
                NavigationService.Navigate(new ErrorPage());
            }
            else
            {
                _resultForm = result;
                DataContext= _resultForm;
            }
        }
        //private async void SearchResultLoaded(object sender, RoutedEventArgs e)
        //{
        //    await LoadSearchData(_searchForm);
        //}

    }
}
