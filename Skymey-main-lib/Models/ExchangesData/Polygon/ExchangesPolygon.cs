using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Skymey_main_lib.Models.ExchangesData.Polygon
{
    public class ExchangesPolygon
    {
        [BsonId(IdGenerator = typeof(ObjectIdGenerator))]
        [JsonPropertyName("_id")]
        public ObjectId? _id { get; set; }
        public int id { get; set; }
        public string type { get; set; }
        public string asset_class { get; set; }
        public string locale { get; set; }
        public string name { get; set; }
        public string acronym { get; set; }
        public string mic { get; set; }
        public string operating_mic { get; set; }
        public string participant_id { get; set; }
        public string url { get; set; }
        public DateTime Update { get; set; }
    }

    public class ExchangesPolygonQuery
    {
        public List<ExchangesPolygon> results { get; set; }
        public string status { get; set; }
        public string request_id { get; set; }
        public int count { get; set; }
    }
}
