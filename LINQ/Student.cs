using System.Collections.Generic;

namespace LINQ
{
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public List<int> Scores;
        
        public Student(){}

        public Student(string first, string last, int id, List<int> scores)
        {
            First = first;
            Last = last;
            ID = id;
            Scores = scores;
        }
    }

// Create a data source by using a collection initializer.
    
}