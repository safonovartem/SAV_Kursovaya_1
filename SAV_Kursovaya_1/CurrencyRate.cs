using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV_Kursovaya_1
{
    public class CurrencyRate
    {
        public DateTime Date { get; set; }
        public decimal Rate { get; set; }

        public CurrencyRate(DateTime date, decimal rate)
        {
            Date = date;
            Rate = rate;
        }
    }
}
