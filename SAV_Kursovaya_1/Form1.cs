using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
// �������� ������ �� System.Windows.Forms.DataVisualization.dll ����� "�������� ������" -> "������" -> "Framework"
using System.Windows.Forms.DataVisualization.Charting;

namespace SAV_Kursovaya_1
{
    public partial class Form1 : Form
    {
        private List<Currency> currencies = new List<Currency>(); // ������������� ����

        public Form1()
        {
            InitializeComponent();
        //    InitializeCurrencies();
        //    InitializeChart();
        }

        // ��� �� ��������, � ���� ����� ���� ��������� ���������� �� Currency � CurrencyRate � ����� ��������������� � ������� System.Windows.Forms.DataVisualization.Charting, �� �� ���������� ��������� ����������

        //private void InitializeCurrencies() // ������������� �����
        //{
        //    // ������ ������
        //    currencies = new List<Currency>(); // ������ �����

        //    Currency usd = new Currency("USD");
        //    Currency eur = new Currency("EUR");

        //    // ��� �������� � �������� ��������
        //    for (int i = 1; i <= 12; i++)
        //    {
        //        usd.AddRate(new DateTime(2025, i, 1), 70 + i);// ���������� ����� ������
        //        eur.AddRate(new DateTime(2025, i, 1), 80 + i * 1.5m); // ���������� ����� ������
        //    }

        //    currencies.Add(usd);
        //    currencies.Add(eur);
        //}

        //private void InitializeChart() // ������������� �������
        //{
        //    Chart chart = new Chart(); // �������� �������
        //    chart.Dock = DockStyle.Fill; // ���������� �������

        //    ChartArea area = new ChartArea("MainArea"); // �������� ������� �������
        //    chart.ChartAreas.Add(area);// ���������� ������� �������

        //    foreach (var currency in currencies) // ������� �����
        //    {
        //        Series series = new Series(currency.Name);// �������� ����� �������
        //        series.ChartType = SeriesChartType.Line;// ��������� ���� �������
        //        series.XValueType = ChartValueType.DateTime; // ��������� ���� ��� X

        //        foreach (var rate in currency.Rates)// ������� ������ ������
        //        {
        //            series.Points.AddXY(rate.Date, rate.Rate);// ���������� ����� �� ������
        //        }

        //        chart.Series.Add(series);// ���������� ����� �� ������
        //    }

        //    this.Controls.Add(chart); // ���������� ������� �� �����
        //}
    }
}