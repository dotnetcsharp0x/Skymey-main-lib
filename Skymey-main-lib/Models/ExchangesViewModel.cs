using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Skymey_main_lib.Models
{
    public class ExchangesViewModel : IDisposable
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("Volume24h")]
        public double Volume24h { get; set; }
        [JsonPropertyName("Trades")]
        public int Trades { get; set; }
        [JsonPropertyName("Pairs")]
        public int Pairs { get; set; }
        [JsonPropertyName("Type")]
        public string Type { get; set; }
        [JsonPropertyName("Blockchain")]
        public string Blockchain { get; set; }

        public void Dispose()
        {
        }
        ~ExchangesViewModel()
        {

        }
    }
}
