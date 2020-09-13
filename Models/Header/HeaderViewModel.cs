using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sailwithdivine.com.Models.Header
{
    public class HeaderViewModel
    {
        public CountryModel Current{ get; set; }
        public CountryModel AvailableCountry { get; set; }
    }

    public class CountryModel
    {
        public string CurrentCountryFlag { get; set; }
        public string CurrentCountryName { get; set; }
    }
}
