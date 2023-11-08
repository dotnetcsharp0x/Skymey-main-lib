using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Skymey_main_lib.Models.JWT
{
    public class AuthenticatedResponseView
    {
        [JsonProperty("accessToken")]
        [JsonPropertyName("accessToken")]
        public string? AccessToken { get; set; }
        [JsonProperty("refreshToken")]
        [JsonPropertyName("refreshToken")]
        public string? RefreshToken { get; set; }
    }
}
