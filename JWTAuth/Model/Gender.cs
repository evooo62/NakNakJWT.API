using System.Collections.Generic;

namespace JWTAuth.Model
{
    public class Gender
    {
        public Gender()
        {
            Students = new HashSet<Student>();
        }
        public int GenderId { get; set; }
        public string Name { get; set; }
        public ICollection<Student> Students{ get; set; }
    }
}
