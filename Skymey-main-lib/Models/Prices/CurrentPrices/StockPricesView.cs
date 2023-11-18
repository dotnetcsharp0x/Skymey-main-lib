using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.IdGenerators;
using Newtonsoft.Json;

namespace Skymey_main_lib.Models.Prices.StockPricesView
{
    public class StockPricesView
    {
        [JsonProperty("Ticker")]
        [JsonPropertyName("Ticker")]
        public string Ticker { get; set; }
        [JsonProperty("Figi")]
        [JsonPropertyName("Figi")]
        public string Figi { get; set; }
        [JsonProperty("Price")]
        [JsonPropertyName("Price")]
        public double Price { get; set; }
        [JsonProperty("Currency")]
        [JsonPropertyName("Currency")]
        public string Currency {  get; set; }
        [JsonProperty("Update")]
        [JsonPropertyName("Update")]
        public DateTime Update { get; set; }

    }
}
