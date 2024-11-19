namespace Group3WebAPI.Models
{
    public class Breakfast
    {
        public int Id { get; set; }

        public string mainCourse { get; set; }

        public string side { get; set; }

        public string drink { get; set; }

        public int preparationTime { get; set; }

        public Breakfast() { }

        public Breakfast(int Id, string mainCourse, string side, int preparationTime) 
        {
            this.Id = Id;
            this.mainCourse = mainCourse;
            this.side = side;
            this.preparationTime = preparationTime;
        }
    }
}
