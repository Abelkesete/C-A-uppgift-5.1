using System;
namespace Uppgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] städer = new string[3];

            städer[0] = "Stockhol";

            städer[1] = "Göteborg";

            städer[2] = "Malmö";


            for (int i = 0; i < städer.Length; i++)
            {
                Console.WriteLine(städer[i] + "\n");
            }


        }
    }
}

