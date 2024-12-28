
using System.Text.Json.Serialization;

namespace Recibro.Models
{
    public class Recipe
    {
        [JsonPropertyName("_id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("ingredients")]
        public string Ingredients { get; set; }
        [JsonPropertyName("instructions")]
        public string Instructions { get; set; }
        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }
    }
}