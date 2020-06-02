using System;

namespace ClassInheritance
{
    public class VIPMember : Member
    {
        public VIPMember(string name, int memberId, int memberSince) : base(name, memberId, memberSince)
        {
            Console.WriteLine("Child Constructor with 3 parameters");
        }

        public override void CalculateAnnualFee()
        {
            annualFee = 1200;
        }
    }
}