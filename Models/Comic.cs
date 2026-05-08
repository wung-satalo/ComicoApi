namespace ComicoApi.Models;

public class Comic
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Image { get; set; } = "";
    public string Category { get; set; } = "";
    public List<Chapter> Chapters { get; set; } = new();
}