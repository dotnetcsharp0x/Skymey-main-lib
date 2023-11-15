using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Skymey_main_lib.Models.CryptoCurrentPricesView
{
    public class CryptoCurrentPricesView
    {
        [JsonPropertyName("ticker")]
        public string Ticker { get; set; }
        [JsonPropertyName("price")]
        public double Price { get; set; }
        [JsonPropertyName("update")]
        public DateTime Update { get; set; }
    }
}
