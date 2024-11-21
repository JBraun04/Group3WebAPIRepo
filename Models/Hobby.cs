//Anthony Arcuri
namespace Group3WebAPI.Models {
    public class Hobby {
        public int Id { get; set; }
        public string hobbyName { get; set; }
        public string hobbyDesc { get; set; }
        public float avgProjCost { get; set; }
        public int hoursPerWeek { get; set; }

        public Hobby() { }
        public Hobby(int Id, string hobbyName, string hobbyDesc, float avgProjCost, int hoursPerWeek) {
            this.Id = Id;
            this.hobbyName = hobbyName;
            this.hobbyDesc = hobbyDesc;
            this.avgProjCost = avgProjCost;
            this.hoursPerWeek = hoursPerWeek;
        }
    }
}
