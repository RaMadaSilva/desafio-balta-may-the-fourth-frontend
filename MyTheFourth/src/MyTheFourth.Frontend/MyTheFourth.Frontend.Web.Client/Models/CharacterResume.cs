using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.Web.Models;

public class CharacterResume
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Name { get; set; } = null!;
}
