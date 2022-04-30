using System.Collections.Generic;

namespace JWTAuth.Model
{
    public class Hobby
    {
        public Hobby()
        {
            StudentHobbies = new HashSet<StudentHobby>();
        }
        public int HobbyId { get; set; }
        public string Name { get; set; }

        public ICollection<StudentHobby> StudentHobbies { get; set; }
    }
}
