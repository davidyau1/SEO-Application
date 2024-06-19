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
    /// Interaction logic for SearchResults.xaml
    /// </summary>
    public partial class SearchResults : Page
    {
        private SearchForm _searchForm;

        public SearchResults(SearchForm searchForm)
        {
            InitializeComponent();
            _searchForm = searchForm;
        }
    }
}
