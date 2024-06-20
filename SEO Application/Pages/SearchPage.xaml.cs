using SEO_Application.Models;
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

namespace SEO_Application.Pages
{
    /// <summary>
    /// Interaction logic for SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Page
    {
        public SearchForm _searchForm { get; set; }
        public SearchPage()
        {
            InitializeComponent();
            _searchForm = new SearchForm() { KeyWord = "conveyancing software",Url= "www.smokeball.com.au" };
            DataContext = _searchForm;
        }
        private void SearchClick(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new SearchResultsPage(_searchForm));
        }

    }
}
