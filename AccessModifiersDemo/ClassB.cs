using System;

namespace AccessModifiersDemo
{
    public class ClassB : ClassA
    {
        public void PrintMessage()
        {
            // This is ok
            Console.WriteLine(publicNum);
            
            // This is ok
            Console.WriteLine(protectedNum);
            
            // This is NOT ok
            //Console.WriteLine(privateNum);
        }
    }
}