using SEO_Application.Controllers;
using SEO_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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