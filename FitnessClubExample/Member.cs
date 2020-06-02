using System;

namespace ClassInheritance
{
    public class Member
    {
        protected int annualFee;
        private string name;
        private int memberId;
        private int memberSince;

        public override string ToString()
        {
            return "\nName: " + name + "\nMember ID: " + memberId + "\nMember Since: " + memberSince +
                   "\nAnnual Fee: " + annualFee;
        }

        public Member()
        {
            Console.WriteLine("Parent Constructor with no parameters");
        }

        public Member(string pName, int pMemberId, int pMemberSince)
        {
            Console.WriteLine("Parent Constructor with 3 parameters");

            this.name = pName;
            this.memberId = pMemberId;
            this.memberSince = pMemberSince;
        }

        public virtual void CalculateAnnualFee()
        {
            annualFee = 0;
        }
    }
    
}