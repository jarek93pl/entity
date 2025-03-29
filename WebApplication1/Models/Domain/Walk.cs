namespace WebApplication1.Models.Domain
{
    public class Walk
    {
        public double LenghtInKm { get; set; }
        public string Descrypion { get; set; }
        public string Name { get; set; }
        public Guid Id { get; set; }
        public Dif dif { get; set; }
        public Region Reg { get; set; }
    }
}
