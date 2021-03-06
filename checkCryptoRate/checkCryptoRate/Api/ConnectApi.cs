﻿using CheckCryptoRate.Models;
using Newtonsoft.Json;
using System;
using System.Net;

namespace CheckCryptoRate.Api
{
    public class ConnectApi
    {
        public BitCoinPrizeData GetCryptocurrencyData(string cryptocurrency, CurrencyType currency)
        {
            var uri = String.Format("https://bitbay.net/API/Public/{0}{1}/ticker.json", cryptocurrency, currency);

            WebClient client = new WebClient();
            client.UseDefaultCredentials = true;
            var data = client.DownloadString(uri);

            BitCoinPrizeData bitCoinPrizeData = JsonConvert.DeserializeObject<BitCoinPrizeData>(data);

            return bitCoinPrizeData;
        }
    }
}
