using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Skymey_main_lib.Models.Prices.Polygon
{
    public class Day
    {
        public double o { get; set; }
        public double h { get; set; }
        public double l { get; set; }
        public double c { get; set; }
        public double v { get; set; }
        public double vw { get; set; }
    }

    public class Min
    {
        public double av { get; set; }
        public double t { get; set; }
        public double n { get; set; }
        public double o { get; set; }
        public double h { get; set; }
        public double l { get; set; }
        public double c { get; set; }
        public double v { get; set; }
        public double vw { get; set; }
    }

    public class PrevDay
    {
        public double o { get; set; }
        public double h { get; set; }
        public double l { get; set; }
        public double c { get; set; }
        public double v { get; set; }
        public double vw { get; set; }
    }

    public class TickerPrices
    {
        public List<Ticker> tickers { get; set; }
        public string status { get; set; }
        public string request_id { get; set; }
        public int count { get; set; }
    }

    public class Ticker
    {
        [BsonId(IdGenerator = typeof(ObjectIdGenerator))]
        [JsonPropertyName("_id")]
        public ObjectId? _id { get; set; }
        public string ticker { get; set; }
        public double todaysChangePerc { get; set; }
        public double todaysChange { get; set; }
        public double updated { get; set; }
        public Day day { get; set; }
        public Min min { get; set; }
        public PrevDay prevDay { get; set; }
        public DateTime Update { get; set; }
    }
}
