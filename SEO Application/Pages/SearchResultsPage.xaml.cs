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
            Task.Run(() => LoadSearchData());

        }


        private void LoadSearchData()
        {
            var result = _searchController.GetSeoPostition(_searchForm);

            //updates ui with result search data
            this.Dispatcher.Invoke(() =>
            {

                if (result == null||string.IsNullOrWhiteSpace(result.Result))
            {
                NavigationService.Navigate(new ErrorPage());
            }
            else
            {
                _resultForm = result;
                DataContext= _resultForm;
            }
            });

        }

    }
}
