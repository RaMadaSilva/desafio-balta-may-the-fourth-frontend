namespace MyTheFourth.Frontend.GalactImpareContext.Models
{
    public class PlanetModel
    {
        public string Name { get; set; } = string.Empty;
        public float RotationPeriod { get; set; }
        public int OrbitalPeriod { get; set; }
        public int Diameter { get; set; }
        public string Climate { get; set; } = string.Empty;
        public string Gravity { get; set; } = string.Empty;
        public string Terrain { get; set; } = string.Empty;
        public float SurfaceWater { get; set; }
        public int Population { get; set; }
        public IEnumerable<ListInfoModel> Characters { get; set; } = Enumerable.Empty<ListInfoModel>();
        public IEnumerable<ListInfoModel> Movies { get; set; } = Enumerable.Empty<ListInfoModel>();
    }
}
