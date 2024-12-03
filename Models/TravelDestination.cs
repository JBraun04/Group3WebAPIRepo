namespace Group3WebAPI.Models
{
    public class TravelDestination
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public int RecommendedDays { get; set; }

        public TravelDestination() { }

        public TravelDestination(int id, string name, string country, string description, decimal cost, int recommendedDays)
        {
            this.Id = id;
            this.Name = name;
            this.Country = country;
            this.Description = description;
            this.Cost = cost;
            this.RecommendedDays = recommendedDays;
        }
    }
}
