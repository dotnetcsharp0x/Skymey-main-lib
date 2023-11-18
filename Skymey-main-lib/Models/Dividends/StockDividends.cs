using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Skymey_main_lib.Models.Dividends
{
    public class StockDividends
    {
        [JsonProperty("Cash_amount")]
        [JsonPropertyName("Cash_amount")]
        public double Cash_amount { get; set; }
        [JsonProperty("Currency")]
        [JsonPropertyName("Currency")]
        public string Currency { get; set; }
        [JsonProperty("Declaration_date")]
        [JsonPropertyName("Declaration_date")]
        public string Declaration_date { get; set; }
        [JsonProperty("Dividend_type")]
        [JsonPropertyName("Dividend_type")]
        public string Dividend_type { get; set; }
        [JsonProperty("Ex_dividend_date")]
        [JsonPropertyName("Ex_dividend_date")]
        public string Ex_dividend_date { get; set; }
        [JsonProperty("Frequency")]
        [JsonPropertyName("Frequency")]
        public int Frequency { get; set; }
        [JsonProperty("Pay_date")]
        [JsonPropertyName("Pay_date")]
        public string Pay_date { get; set; }
        [JsonProperty("Record_date")]
        [JsonPropertyName("Record_date")]
        public string Record_date { get; set; }
        [JsonProperty("Ticker")]
        [JsonPropertyName("Ticker")]
        public string Ticker { get; set; }
        [JsonProperty("Update")]
        [JsonPropertyName("Update")]
        public DateTime Update { get; set; }
    }
}
