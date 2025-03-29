namespace WebApplication1.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public Guid Name { get; set; }
        public string Code { get; set; }
        public string? RegionImageIrl { get; set; }
    }
}
