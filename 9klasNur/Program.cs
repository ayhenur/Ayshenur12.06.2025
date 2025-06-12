using System.Collections.Immutable;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _9klasNur
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*
            int[] arr = new int[3];
            int[,] arr2 = new int[3, 7];
            arr2[0, 0] = 1;
            arr2[0, 1] = 2;
            arr2[0, 2] = 3; 
            arr2[0, 0] = 4;
            arr2[0, 1] = 5;
            arr2[0, 2] = 6;

            int[,,] arr3 = new int[3, 4, 5];

            int[] ar = {3, 2, 56, 6 }; 
            */
            /*
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            */

            /*
            int[] size = Console.ReadLine()
               .Split(" ")
               .Select(int.Parse)
               .ToArray();

            int rows = 0;
            int cols = 0;

            int[,] matrix = 
            for (int i = 0; i < size.Length; i++)
            {

            }
            */
            /*
            Dictionary <string, int> pair=new Dictionary<string, int> ();

            pair["ivan"] = 15;
            pair["gogo"] = 90;
            Console.WriteLine(pair["ivan"]);

            pair["ivan"] = 110;
            foreach(var item in pair)
            { 
                Console.WriteLine($"{item.Key} --> {item.Value}");
            }

            Console.WriteLine(new string('*',10));

            pair.Remove("Ivan");
            foreach (var item in pair)
            {
                Console.WriteLine($"{item.Key} --> {item.Value}");
            }
            */

            string line = Console.ReadLine();
            string[] words = line.Split(" ");

            Dictionary< string, int > pair = new Dictionary<string, int>();
            foreach (string word in words)
            {
                pair.Add(word, 0);
            }

















































        }
    }
}
