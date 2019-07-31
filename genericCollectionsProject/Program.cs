using System;
using System.Collections.Generic;

namespace genericCollectionsProject {
    class Program {
        static void Main(string[] args) {

            var customers = new Customers();
            customers.LoadCustomers();

            customers.PrintCustomers();
        }
        static void Run() { 

            List<int> scores = new List<int>( );

            Random rnd = new Random();
            int total = 0;
            int highScore = 0;

            do {
                int listIdx = 0;
                for (int i = 0; i < 10; i++) {
                    scores.Add(rnd.Next(31));
                }
                foreach (var score in scores) {
                    total += score;
                }
                if (highScore < total) {
                    highScore = total;
                } else {
                    highScore = 0;        
                }
                total = 0;

            } while (highScore < 294);

            
            Console.WriteLine($"Total score is {highScore}");
            
            
            
            //List<string> names = new List<string>();


            //var integers = new List<int>();

            //integers.Add(13);
            //integers.Add(7);
            //integers.Add(4);

            //integers.Remove(4);

            //integers.AddRange(new int[] { 4, 44, 444, 4444 });

            //integers[3] = 99;

            //foreach (var i in integers) {
            //    Console.WriteLine($"i = {i}");
            //}
        }
    }
}
