﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Skymey_main_lib.Models.Tables.User
{
    public class SU_001LoginViewModel
    {
        [JsonProperty("Email")]
        [JsonPropertyName("Email")]
        public string Email { get; set; }
        [JsonProperty("Password")]
        [JsonPropertyName("Password")]
        public string Password { get; set; }
    }
    public class SU_001RegisterViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    public class SU_001ListViewModel
    {
        [Key]
        [JsonProperty("Id")]
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonProperty("FirstName")]
        [JsonPropertyName("FirstName")]
        public string? FirstName { get; set; }
        [JsonProperty("FirsLastNametName")]
        [JsonPropertyName("LastName")]
        public string? LastName { get; set; }
        [JsonProperty("Email")]
        [JsonPropertyName("Email")]
        public string Email { get; set; }
        [JsonProperty("Password")]
        [JsonPropertyName("Password")]
        public string Password { get; set; }
        [JsonProperty("RefreshToken")]
        [JsonPropertyName("RefreshToken")]
        public string? RefreshToken { get; set; }
        [JsonProperty("RefreshTokenExpiryTime")]
        [JsonPropertyName("RefreshTokenExpiryTime")]
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
