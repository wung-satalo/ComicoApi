using System.Text.Json;

namespace ComicoApi.Models;

public class Chapter
{
    public int Id { get; set; }
    public int ComicId { get; set; }
    public string Name { get; set; } = "";
    public string LinksJson { get; set; } = "[]";

    public List<string> Links
    {
        get => JsonSerializer.Deserialize<List<string>>(LinksJson) ?? new();
        set => LinksJson = JsonSerializer.Serialize(value);
    }
}