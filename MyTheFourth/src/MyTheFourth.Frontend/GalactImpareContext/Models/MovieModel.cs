namespace MyTheFourth.Frontend.GalactImpareContext.Models;

public class MovieModel
{
    public string Title { get; set; } = string.Empty;
    public int Episode { get; set; }
    public string OpeningCrawl { get; set; } = string.Empty;
    public string Director { get; set; } = string.Empty;
    public string Producer { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; }
    public DateTime Created { get; set; }
    public DateTime Edited { get; set; }
    public IEnumerable<ListInfoModel> Starships { get; set; } = Enumerable.Empty<ListInfoModel>();
    public IEnumerable<ListInfoModel> Planets { get; set; } = Enumerable.Empty<ListInfoModel>();
    public IEnumerable<ListInfoModel> Vehicles { get; set; } = Enumerable.Empty<ListInfoModel>();
    public IEnumerable<ListInfoModel> Characters { get; set; } = Enumerable.Empty<ListInfoModel>(); 
}