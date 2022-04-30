namespace JWTAuth.Model
{
    public class StudentHobby
    {
        public int StudentId { get; set; }
        public int HobbyId { get; set; }

        public Student Student { get; set; }
        public Hobby Hobby { get; set; }
    }
}
