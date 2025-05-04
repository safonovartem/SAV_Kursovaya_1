using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV_Kursovaya_1
{
    public class Currency
    {
        public string Name { get; set; }
        public List<CurrencyRate> Rates { get; set; }

        public Currency(string name)
        {
            Name = name;
            Rates = new List<CurrencyRate>();
        }

        public void AddRate(DateTime date, decimal rate)
        {
            Rates.Add(new CurrencyRate(date, rate));
        }
    }
}
