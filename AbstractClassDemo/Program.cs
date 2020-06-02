using System;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
             // MyClass abClass = new MyClass(); -> Raises an error, because abstract class cannot be instanciated
             ClassA a = new ClassA();
             a.PrintMessage();
             a.PrintMessageAbstract();
        }
    }
}