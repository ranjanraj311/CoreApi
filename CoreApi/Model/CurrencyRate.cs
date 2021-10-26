using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.Model
{
    public class CurrencyRate
    {
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyUSDValue { get; set; }
    }
}
