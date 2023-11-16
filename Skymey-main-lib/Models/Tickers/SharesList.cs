using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Skymey_main_lib.Models.Tickers
{
    public class SharesList
    {
        [JsonProperty("Ticker")]
        [JsonPropertyName("Ticker")]
        public string Ticker { get; set; }
        [JsonProperty("Name")]
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonProperty("Market")]
        [JsonPropertyName("Market")]
        public string Market { get; set; }
        [JsonProperty("Locale")]
        [JsonPropertyName("Locale")]
        public string Locale { get; set; }
        [JsonProperty("Type")]
        [JsonPropertyName("Type")]
        public string Type { get; set; }
        [JsonProperty("Currency_name")]
        [JsonPropertyName("Currency_name")]
        public string Currency_name { get; set; }
        [JsonProperty("Last_updated_utc")]
        [JsonPropertyName("Last_updated_utc")]
        public DateTime Last_updated_utc { get; set; }
        [JsonProperty("Composite_figi")]
        [JsonPropertyName("Composite_figi")]
        public string Composite_figi { get; set; }
        [JsonProperty("Share_class_figi")]
        [JsonPropertyName("Share_class_figi")]
        public string Share_class_figi { get; set; }
        [JsonProperty("Primary_exchange")]
        [JsonPropertyName("Primary_exchange")]
        public string Primary_exchange { get; set; }
        [JsonProperty("Cik")]
        [JsonPropertyName("Cik")]
        public string Cik { get; set; }
        [JsonProperty("Update")]
        [JsonPropertyName("Update")]
        public DateTime Update { get; set; }
    }
}
