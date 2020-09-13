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
        public string CountryFlag { get; set; }
        public string CountryName { get; set; }
        public string Culture { get; set; }
    }
}
