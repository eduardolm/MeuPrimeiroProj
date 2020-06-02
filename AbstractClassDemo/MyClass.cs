using System;

namespace AbstractClassDemo
{
    public abstract class MyClass
    {
        private string message = "Hello C#";

        public void PrintMessage()
        {
            Console.WriteLine(message);
        }

        public abstract void PrintMessageAbstract(); // Abstract method
    }
}