﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Skymey_main_lib.Models.Prices.StockPrices
{
    public class StockPrices
    {
        [BsonId(IdGenerator = typeof(ObjectIdGenerator))]
        [JsonPropertyName("_id")]
        public ObjectId? _id { get; set; }
        public string Ticker { get; set; }
        public string Figi { get; set; }
        public double Price { get; set; }
        public DateTime Update { get; set; }

    }
}
