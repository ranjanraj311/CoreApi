using CoreApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyRateController : ControllerBase
    {
        [HttpGet]
        public async Task<List<CurrencyRate>> GetCurrencyDetails()
        {
            CurrencyRate objEURO = new CurrencyRate()
            {
                CurrencyName = "Euro",
                CurrencyCode = "EUR",
                CurrencyUSDValue = "0.85957148"
            };
            CurrencyRate objAUD = new CurrencyRate()
            {
                CurrencyName = "Australian Dollar",
                CurrencyCode = "AUD",
                CurrencyUSDValue = "1.33511362"
            };
            CurrencyRate objCHF = new CurrencyRate()
            {
                CurrencyName = "Swiss Franc",
                CurrencyCode = "CHF",
                CurrencyUSDValue = "0.91868019"
            };
            CurrencyRate objCAD = new CurrencyRate()
            {
                CurrencyName = "Canadian Dollar",
                CurrencyCode = "CAD",
                CurrencyUSDValue = "1.23711550"
            };
            CurrencyRate objJPY = new CurrencyRate()
            {
                CurrencyName = "Japanese Yen",
                CurrencyCode = "JPY",
                CurrencyUSDValue = "113.68468514"
            };
            CurrencyRate objMRO = new CurrencyRate()
            {
                CurrencyName = "Mauritanian Ouguiya",
                CurrencyCode = "MRO",
                CurrencyUSDValue = "36.20950022"
            };
            CurrencyRate objCOP = new CurrencyRate()
            {
                CurrencyName = "Colombian Peso",
                CurrencyCode = "COP",
                CurrencyUSDValue = "3,771.05282492"
            };
            CurrencyRate objBND = new CurrencyRate()
            {
                CurrencyName = "Brunei Dollar",
                CurrencyCode = "BND",
                CurrencyUSDValue = "1.34704177"
            };
            CurrencyRate objKMF = new CurrencyRate()
            {
                CurrencyName = "Comoro franc",
                CurrencyCode = "KMF",
                CurrencyUSDValue = "423.93217429"
            };
            CurrencyRate objSZL = new CurrencyRate()
            {
                CurrencyName = "Swazi lilangeni",
                CurrencyCode = "SZL",
                CurrencyUSDValue = "14.57638376"
            };

            List<CurrencyRate> list = new List<CurrencyRate>();
            list.Add(objEURO);
            list.Add(objAUD);
            list.Add(objCHF);
            list.Add(objCAD);
            list.Add(objJPY);
            list.Add(objMRO);
            list.Add(objCOP);
            list.Add(objBND);
            list.Add(objKMF);
            list.Add(objSZL);

            return list;
        }
    }
}
