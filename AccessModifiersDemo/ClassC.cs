using System;

namespace AccessModifiersDemo
{
    public class ClassC
    {
        ClassA a = new ClassA();

        public void PrintMessage()
        {
            // This is ok
            //Console.WriteLine(a.publicNum);
            
            // This is NOT ok
            //Console.WriteLine(a.protectedNum);
            
            // This is NOT ok
            //Console.WriteLine(a.privateNum);
        }
    }
}