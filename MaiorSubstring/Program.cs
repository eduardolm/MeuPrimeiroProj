using System;

namespace MaiorSubstring
{
    class Program
        {
            static void Main(string[] args)
            {
                var maxLength = 0;
                var input1 = Console.ReadLine();
                var input2 = Console.ReadLine();
                
                while (input1 != "")
                {
                    if (input1 != null && input2 != null)
                    {
                        var str1 = input1.ToCharArray();
                        var str2 = input2.ToCharArray();
                        var search = new int[str1.Length + 1, str2.Length + 1];

                        for (var i = 1; i <= str1.Length; i++)
                        {
                            for (var j = 1; j <= str2.Length; j++)
                            {
                                if (str1[i - 1].Equals(str2[j - 1]))
                                {
                                    search[i, j] = search[i - 1, j - 1] + 1;

                                    if (search[i, j] > maxLength)
                                    {
                                        maxLength = search[i, j];
                                    }
                                }
                            }
                        }
                        Console.WriteLine(maxLength);
                        maxLength = 0;
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