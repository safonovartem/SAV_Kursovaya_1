using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAV_Kursovaya_1
{
    public class CurrencyRate // даты курсов - класс
    {
        public string[] USD_Currency = new string[134]; // список для дат курса USD
        public string[] EUR_Currency = new string[134]; // список для дат курса EUR
        public string[] CNY_Currency = new string[134]; // список для дат курса CNY

        public CurrencyRate(string USD_Currency, string EUR_Currency, string CNY_Currency)
        { // тут тоже считывать txt файлы

        }
    }
}
