namespace Group3WebAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        //length in MINUTES
        public int length { get; set; }
        public int releaseYear { get; set; }

        public Movie() { }
        public Movie(int id, string title, string genre, int length, int releaseYear)
        {
            this.Id = id;
            this.title = title;
            this.genre = genre;
            this.length = length;
            this.releaseYear = releaseYear;
        }

    }
}
