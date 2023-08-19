using System.Text.Json.Serialization;

namespace TuiFly.FlySearchApi.Domain.Models
{
    /// <summary>
    /// the airport dto model
    /// </summary>
    public class AirportDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("available")]
        public bool Available { get; set; }

        [JsonPropertyName("countryName")]
        public string CountryName { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
