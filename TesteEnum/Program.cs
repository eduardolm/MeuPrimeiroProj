using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = EnumUtil.GetValues<Names>();
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(values.ToList()[0]);
            var edu = new Status();
            edu.Name = Names.Backend;
            Console.WriteLine(edu.Name);
        }

        public enum Names
        {
            Backend = 1,
            Frontend = 2,
            Mobile = 3,
            Desktop = 4
        }
        
        public static class EnumUtil {
            public static IEnumerable<T> GetValues<T>() {
                return Enum.GetValues(typeof(T)).Cast<T>().ToList();
            }
        }

        public class Status
        {
            public Names Name { get; set; }
        }
    }
}