using System;
using System.Linq;

namespace FlatArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][]; // define an array of arrays
            arr[0] = new int[3] { 1, 2, 3 };
            arr[1] = new int[2] { 4, 5 };
            arr[2] = new int[1] { 6 };

            var res = FlatArray(arr); // call the method to flat array
            for (var i = 0; i < res.Count(); i++)
            {
                Console.WriteLine(res[i]); // show result to user
            }
            Console.ReadKey();
        }

        private static int[] FlatArray(int[][] arr)
        {
            var res = arr.SelectMany(x => x).Distinct(); // shortest code to flat arrays inside array
            return res.ToArray();
        }
    }
}
