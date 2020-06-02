using System;

namespace LINQ
{
    public class Player
    {
        public Player(long id, long teamId, string name, DateTime birthDate, int skillLevel, decimal salary)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            SkillLevel = skillLevel;
            Salary = salary;
        }

        public Player()
        {
        }
        public long Id { get; set; }
        
        public string Name { get; set; }
        
        public DateTime BirthDate { get; set; }
        
        public int SkillLevel { get; set; }
        
        public decimal Salary { get; set; }
    }
}