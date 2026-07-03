using System.Runtime.InteropServices;

namespace StudentApi.Model
{
    public class Student
    {
        public int StudentId { get; set; }

        public int RollNo { get; set; } 

        public string? Fname { get; set; }

        public string? Lname { get; set; }

        public int standard { get; set; }
        public string? Division { get; set; }

        public string? Gender { get; set; }

        public string? Address { get; set; }
    }
}
