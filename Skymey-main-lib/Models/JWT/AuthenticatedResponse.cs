using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Skymey_main_lib.Models.JWT
{
    public class AuthenticatedResponse
    {
        [JsonProperty("AccessToken")]
        [JsonPropertyName("AccessToken")]
        public string? AccessToken { get; set; }
        [JsonProperty("RefreshToken")]
        [JsonPropertyName("RefreshToken")]
        public string? RefreshToken { get; set; }
    }
}
