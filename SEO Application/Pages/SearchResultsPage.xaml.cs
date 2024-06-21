using SerpAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SEO_Application.Controllers;
using SEO_Application.Models;
namespace SEO_Application.Pages
{
    /// <summary>
    /// Interaction logic for SearchResultsPage.xaml
    /// </summary>
    public partial class SearchResultsPage : Page
    {
        private SearchForm _searchForm;
        private SearchController _searchController;
        public SearchResultsPage(SearchForm searchForm)
        {
            InitializeComponent();
            _searchForm = searchForm;
            var result = _searchController.GetSeoPostition(searchForm);
            DataContext=new ResultForm() { Result =result};
        }
    }
}
