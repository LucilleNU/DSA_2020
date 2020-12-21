using System;
namespace Lecture_7
{
    class Students
    {
        public string name;
        public int studentNumber;
        public Students(string name, int studentNumber)
        {
            Name = name;
            StudentNumber = studentNumber;
        }
        public string Name { get; set; }
        public int StudentNumber { get; set; }
    }
}
