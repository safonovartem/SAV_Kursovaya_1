using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV_Kursovaya_1
{
    public class Currency // валюта - класс
    {
        public int [] USD_Currency = new int[134]; // список для курса USD
        public int[] EUR_Currency = new int[134]; // список для курса EUR
        public int[] CNY_Currency = new int[134]; // список для курса CNY

        public Currency(List<double> USD_Currency, List<double> EUR_Currency, List<double> CNY_Currency)// конструктор класса
        {
            // тут я хочу, чтобы считывались txt файлы с курсами валют
            //this.USD_Currency = [113,71, 111,0, 110,43] ;
            //this.EUR_Currency = [];
            //this.CNY_Currency = [];
        }

        //public string Name { get; set; } // название валюты
        //public List<CurrencyRate> Rates { get; set; } // список курсов валюты

        //public Currency(string name) // конструктор класса
        //{
        //    Name = name;
        //    Rates = new List<CurrencyRate>();
        //}

        //public void AddRate(DateTime date, decimal rate) // добавление курса валюты
        //{
        //    Rates.Add(new CurrencyRate(date, rate));// добавление нового курса валюты в список
        //}
    }
}
