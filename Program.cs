using System;
using System.Collections.Generic;

namespace CadernoTestes
{
    class Program
    {
        static void Main(string[] args)
        {
            var sul = new List<string>{"Paraná", "Santa Catarina", "Rio Grande do Sul"};

            foreach (var estado in sul)
            {
                Console.WriteLine(estado.ToUpper().Trim());
            }

            Console.ReadLine();
        }
    }
}
