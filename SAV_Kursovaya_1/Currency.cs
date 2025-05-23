using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV_Kursovaya_1
{
    public class Currency // валюта - класс
    {
        public string Name { get; set; } // название валюты
        public List<CurrencyRate> Rates { get; set; } // список курсов валюты

        public Currency(string name) // конструктор класса
        {
            Name = name;
            Rates = new List<CurrencyRate>();
        }

        public void AddRate(DateTime date, decimal rate) // добавление курса валюты
        {
            Rates.Add(new CurrencyRate(date, rate));// добавление нового курса валюты в список
        }
    }
}
