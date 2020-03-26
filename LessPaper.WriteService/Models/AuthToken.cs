using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace LessPaper.WriteService.Models
{
    public class AuthToken
    {
        [Required]
        [JsonPropertyName("token")]
        [ModelBinder(Name = "token")]
        public string Token { get; set; }

        [Required]
        [JsonPropertyName("refresh_token")]
        [ModelBinder(Name = "refresh_token")]
        public string RefreshToken { get; set; }

    }
}
