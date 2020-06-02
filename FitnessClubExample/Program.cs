using System;

namespace ClassInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*        Previous version of the method
             
            // Create an object of each class
            NormalMember normalMember = new NormalMember("Special Rate", "James", 1, 2010);
            VIPMember vipMember = new VIPMember("Andy", 2, 2011);
            
            // Calculate annual fee for each object
            normalMember.CalculateAnnualFee();
            vipMember.CalculateAnnualFee();
            
            // Prints out the result, using customized ToString()
            Console.WriteLine(normalMember.ToString());
            Console.WriteLine(vipMember.ToString()); */
            
            Member[] clubMembers = new Member[5];
            
            clubMembers[0] = new NormalMember("Special Rate", "James", 1, 2010);
            clubMembers[1] = new NormalMember("Normal Rate", "Andy", 2, 2011);
            clubMembers[2] = new NormalMember("Normal Rate", "Bill", 3, 2011);
            clubMembers[3] = new VIPMember("Carol", 4, 2012);
            clubMembers[4] = new VIPMember("Evelyn", 5, 2012);

            foreach (Member member in clubMembers)
            {
                member.CalculateAnnualFee();
                Console.WriteLine(member.ToString());
            }
            
            // GetType() and typeof()
            if (clubMembers[0].GetType() == typeof(VIPMember))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}