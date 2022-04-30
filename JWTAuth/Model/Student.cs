using System.Collections.Generic;

namespace JWTAuth.Model
{
    public class Student
    {
        public Student()
        {
            StudentHobbies = new HashSet<StudentHobby>();
        }
        public int StudentId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int? GenderId { get; set; }

        public Gender Gender { get; set; }
        public ICollection<StudentHobby> StudentHobbies { get; set; }
    }
}
