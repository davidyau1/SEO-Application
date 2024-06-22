using Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public interface ISearchController
    {
        public ResultForm GetSeoPostition(SearchForm searchForm);

    }
}
