using System;

namespace TesteMaiorString
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();
            var temp = 0;
            var response = 0;
                
            while (input1 != "")
            {
                if (input1 != null && input2 != null)
                {
                    var largeStr = input1.Length > input2.Length ? input1 : input2;
                    var smallStr = input1.Length > input2.Length ? input2 : input1;

                    for (var i = 0; i < largeStr.Length; i++)
                    {
                        for (var j = 0; j < smallStr.Length; j++)
                        {
                            if (largeStr.Contains(smallStr))
                            {
                                temp++;
                            }
                            else if (response < temp)
                            {
                                response = temp;
                                temp = 0;
                            }
                        }
                    }
                    Console.WriteLine(response);
                }
                else
                {
                    return;
                }
        
                input1 = Console.ReadLine();
                input2 = Console.ReadLine();
            }
        }
    }
}