using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoinGecko.Clients;
using System.Net.Http;
using Xunit;
using CoinGecko.Entities.Response.Coins;
using CoinGecko.Interfaces;
using CoinGecko.Parameters;
using System.Timers;

namespace CryptoWidgetBtc
{
    public class Gecko
    {
        private ICoinGeckoClient _client;

        [STAThread]
        public async Task Start(Form1 form)
        {
            _client = CoinGeckoClient.Instance;

            string ids = "bitcoin";
            string vsCurrencies = "usd";

            var result = await _client.SimpleClient.GetSimplePrice(new[] { ids }, new[] { vsCurrencies });
            Assert.False(string.IsNullOrEmpty(result[ids][vsCurrencies]?.ToString()));

            form.SetText((result[ids][vsCurrencies].ToString()));

        }
        public async Task StartEth(Form1 form)
        {
            string ids = "ethereum";
            string vsCurrencies = "usd";

            var result = await _client.SimpleClient.GetSimplePrice(new[] { ids }, new[] { vsCurrencies });
            Assert.False(string.IsNullOrEmpty(result[ids][vsCurrencies]?.ToString()));

            form.SetTextEth((result[ids][vsCurrencies].ToString()));


        }

        public async Task StartMatic(Form1 form)
        {
            string ids = "matic-network";
            string vsCurrencies = "usd";

            var result = await _client.SimpleClient.GetSimplePrice(new[] { ids }, new[] { vsCurrencies });
            Assert.False(string.IsNullOrEmpty(result[ids][vsCurrencies]?.ToString()));

            form.SetTextMatic((result[ids][vsCurrencies].ToString()));
        }

    }
    public class Program
    {
        static Form1 form;
        static Gecko gecko;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static void Main()
        {
             form = new Form1();
             gecko = new Gecko();

            Application.EnableVisualStyles();

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

             t.Interval = 5000;
             t.Tick += new EventHandler(timer_Tick);
             t.Start();
            
            gecko.Start(form);
            gecko.StartEth(form);
            gecko.StartMatic(form);
            Application.Run(form);
        }

        static void Update()
        {
            gecko.Start(form);
            gecko.StartEth(form);
            gecko.StartMatic(form);
        }
        static void timer_Tick(object sender, EventArgs e)
        {
            Update();
        }

    }
}
