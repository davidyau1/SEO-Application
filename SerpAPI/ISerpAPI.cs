using SerpAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpAPILibrary
{
    public interface ISerpAPI
    {
        public List<OrganicResult> GetOrganicResults(GetSerp searchForm);

    }
}
