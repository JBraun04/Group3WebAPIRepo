namespace Group3WebAPI.Models
{
    public class Movie
    {
        public int Id;
        public string title;
        public string genre;
        //length in MINUTES
        public int length;
        public int releaseYear;

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
