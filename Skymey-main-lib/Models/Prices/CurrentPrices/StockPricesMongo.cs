using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Skymey_main_lib.Models.Prices.StockPricesMongo
{
    public class StockPricesMongo
    {
        [BsonId(IdGenerator = typeof(ObjectIdGenerator))]
        [JsonPropertyName("_id")]
        public ObjectId? _id { get; set; }
        [JsonPropertyName("ticker")]
        public string Ticker { get; set; }
        [JsonPropertyName("figi")]
        public string Figi { get; set; }
        [JsonPropertyName("price")]
        public double Price { get; set; }
        [JsonPropertyName("currency")]
        public string Currency {  get; set; }
        [JsonPropertyName("update")]
        public DateTime Update { get; set; }
    }
}
