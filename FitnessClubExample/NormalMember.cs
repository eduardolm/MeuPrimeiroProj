using System;

namespace ClassInheritance
{
    public class NormalMember : Member
    {
        public NormalMember()
        {
            Console.WriteLine("Child Constructor with no parameters");
        }

        public NormalMember(string remarks, string name, int memberId, int memberSince) : base(name, memberId, memberSince)
        {
            Console.WriteLine("Child Constructor with 4 parameters");
            Console.WriteLine("Remarks = {0}", remarks);
        }

        public override void CalculateAnnualFee()
        {
            annualFee = 100 + 12 * 30;
        }
    }
}