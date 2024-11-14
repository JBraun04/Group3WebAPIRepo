namespace Group3WebAPI.Models
{
    public class TeamMember
    {   
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Year { get; set; }
        public int Age { get; set; }
        public TeamMember() { }
        public TeamMember(int id, string firstName, string lastName, string year, int age)
        {
            Id = id;
            First_name = firstName;
            Last_name = lastName;
            Year = year;
            Age = age;
        }
    }
}
