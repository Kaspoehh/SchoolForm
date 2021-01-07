﻿using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsForms
{
	public partial class Form1 : Form
	{
		List<string> valutas = new List<string>();

		public Form1()
		{
			InitializeComponent();

			GetValutas();

			for (int i = 0; i < valutas.Count; i++)
			{
				ValutaBox.Items.Add(valutas[i]);
			}

		}

		private void GetValutas()
		{
            ConversionRate conversionRates = new ConversionRate();

            foreach (var prop in conversionRates.GetType().GetProperties())
            {
                valutas.Add(prop.Name);
            }

        }

		private void button1_Click(object sender, System.EventArgs e)
		{

		}

        
    }


    class Rates
    {
        public static bool Import()
        {
            string URLString = "https://v6.exchangerate-api.com/v6/4c6472e788470054d03d83ac/latest/EUR";

            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(URLString);
                API_Obj Test = JsonConvert.DeserializeObject<API_Obj>(json);

                return true;
            }            
        }
    }

    public class API_Obj
    {
        public string result { get; set; }
        public string documentation { get; set; }
        public string terms_of_use { get; set; }
        public string time_zone { get; set; }
        public string time_last_update { get; set; }
        public string time_next_update { get; set; }
        public ConversionRate conversion_rates { get; set; }
    }

    public class ConversionRate
    {
        public double AED { get; set; }
        public double ARS { get; set; }
        public double AUD { get; set; }
        public double BGN { get; set; }
        public double BRL { get; set; }
        public double BSD { get; set; }
        public double CAD { get; set; }
        public double CHF { get; set; }
        public double CLP { get; set; }
        public double CNY { get; set; }
        public double COP { get; set; }
        public double CZK { get; set; }
        public double DKK { get; set; }
        public double DOP { get; set; }
        public double EGP { get; set; }
        public double EUR { get; set; }
        public double FJD { get; set; }
        public double GBP { get; set; }
        public double GTQ { get; set; }
        public double HKD { get; set; }
        public double HRK { get; set; }
        public double HUF { get; set; }
        public double IDR { get; set; }
        public double ILS { get; set; }
        public double INR { get; set; }
        public double ISK { get; set; }
        public double JPY { get; set; }
        public double KRW { get; set; }
        public double KZT { get; set; }
        public double MXN { get; set; }
        public double MYR { get; set; }
        public double NOK { get; set; }
        public double NZD { get; set; }
        public double PAB { get; set; }
        public double PEN { get; set; }
        public double PHP { get; set; }
        public double PKR { get; set; }
        public double PLN { get; set; }
        public double PYG { get; set; }
        public double RON { get; set; }
        public double RUB { get; set; }
        public double SAR { get; set; }
        public double SEK { get; set; }
        public double SGD { get; set; }
        public double THB { get; set; }
        public double TRY { get; set; }
        public double TWD { get; set; }
        public double UAH { get; set; }
        public double USD { get; set; }
        public double UYU { get; set; }
        public double ZAR { get; set; }
    }
}
