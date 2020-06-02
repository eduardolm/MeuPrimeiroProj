using System;

namespace InterfaceDemo
{
    public class ClassA : IShape
    {
        private int myNumber;
        public int MyNumber
        {
            get
            {
                return myNumber;
            }
            set
            {
                if (value < 0)
                    myNumber = 0;
                else
                    myNumber = value;
            }
        }

        public void InterfaceMethod()
        {
            Console.WriteLine("The number is: {0}", MyNumber);
        }
    }
}