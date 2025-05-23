using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
// Добавить ссылку на System.Windows.Forms.DataVisualization.dll через "Добавить ссылку" -> "Сборки" -> "Framework"
using System.Windows.Forms.DataVisualization.Charting;

namespace SAV_Kursovaya_1
{
    public partial class Form1 : Form
    {
        private List<Currency> currencies = new List<Currency>(); // инициализация поля

        public Form1()
        {
            InitializeComponent();
        //    InitializeCurrencies();
        //    InitializeChart();
        }

        // Это не работает, я хочу чтобы сюда приходила информация из Currency и CurrencyRate и затем визуализировало с помощью System.Windows.Forms.DataVisualization.Charting, но не получается попомгите пожалуйста

        //private void InitializeCurrencies() // инициализация валют
        //{
        //    // Пример данных
        //    currencies = new List<Currency>(); // список валют

        //    Currency usd = new Currency("USD");
        //    Currency eur = new Currency("EUR");

        //    // Для простоты — месячные значения
        //    for (int i = 1; i <= 12; i++)
        //    {
        //        usd.AddRate(new DateTime(2025, i, 1), 70 + i);// добавление курса валюты
        //        eur.AddRate(new DateTime(2025, i, 1), 80 + i * 1.5m); // добавление курса валюты
        //    }

        //    currencies.Add(usd);
        //    currencies.Add(eur);
        //}

        //private void InitializeChart() // инициализация графика
        //{
        //    Chart chart = new Chart(); // создание графика
        //    chart.Dock = DockStyle.Fill; // заполнение графика

        //    ChartArea area = new ChartArea("MainArea"); // создание области графика
        //    chart.ChartAreas.Add(area);// добавление области графика

        //    foreach (var currency in currencies) // перебор валют
        //    {
        //        Series series = new Series(currency.Name);// создание серии графика
        //        series.ChartType = SeriesChartType.Line;// установка типа графика
        //        series.XValueType = ChartValueType.DateTime; // установка типа оси X

        //        foreach (var rate in currency.Rates)// перебор курсов валюты
        //        {
        //            series.Points.AddXY(rate.Date, rate.Rate);// добавление точки на график
        //        }

        //        chart.Series.Add(series);// добавление серии на график
        //    }

        //    this.Controls.Add(chart); // добавление графика на форму
        //}
    }
}