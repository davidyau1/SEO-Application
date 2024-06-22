using System.Windows.Controls;
using Controllers.Models;
namespace SEO_Application.Pages
{
    /// <summary>
    /// Interaction logic for SearchResultsPage.xaml
    /// </summary>
    public partial class SearchResultsPage : Page
    {
        private SearchForm _searchForm;
        public SearchResultsPage(ResultForm resultForm)
        {
            InitializeComponent();
            DataContext = resultForm;
        }
    }
}
