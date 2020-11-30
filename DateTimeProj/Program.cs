using System;

namespace DateTimeProj
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = DateTimeOffset.FromUnixTimeMilliseconds(1597201945697);
            Console.WriteLine(time.ToString());
        }
    }
}