using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actual_Part_1

{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "David";
            string movie = "The Matrix";
            string word = "THE";
            string sentence = ($"My name is {name.ToLower()} and my favourite movie is {movie.ToUpper()}");

            Console.WriteLine("DDDD   TTTTT");
            Console.WriteLine("D    D   T");
            Console.WriteLine("D    D   T");
            Console.WriteLine("D    D   T");
            Console.WriteLine("D    D   T");
            Console.WriteLine("DDDD     T");

            Console.WriteLine(sentence.Contains("THE"));

            Console.WriteLine(sentence.Replace("a" , "@"));
            Console.WriteLine(sentence.Replace("e", "3"));
            Console.ReadLine();
        }
    }
}