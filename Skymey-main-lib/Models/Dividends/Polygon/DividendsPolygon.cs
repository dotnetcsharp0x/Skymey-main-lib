using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Skymey_main_lib.Models.Dividends.Polygon
{
    public class DividendsPolygon
    {
        [BsonId(IdGenerator = typeof(ObjectIdGenerator))]
        [JsonPropertyName("_id")]
        public ObjectId? _id { get; set; }
        public double cash_amount { get; set; }
        public string currency { get; set; }
        public string declaration_date { get; set; }
        public string dividend_type { get; set; }
        public string ex_dividend_date { get; set; }
        public int frequency { get; set; }
        public string pay_date { get; set; }
        public string record_date { get; set; }
        public string ticker { get; set; }
        public DateTime Update { get; set; }
    }

    public class DividendsPolygonQuery
    {
        public List<DividendsPolygon> results { get; set; }
        public string status { get; set; }
        public string request_id { get; set; }
    }
}
