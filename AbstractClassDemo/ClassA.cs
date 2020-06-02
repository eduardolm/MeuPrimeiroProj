using System;

namespace AbstractClassDemo
{
    public class ClassA : MyClass
    {
        public override void PrintMessageAbstract()
        {
            Console.WriteLine("C# is fun!");
        }
    }
}