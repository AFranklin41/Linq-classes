using System;
using System.Collections.Generic;
using System.Linq;

namespace linqChapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Find the words in the collection that start with the letter 'L'
            // List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            // IEnumerable<string> LFruits = fruits.Where(fruit => fruit.Substring(0, 1) == "L");

            // // IEnumerable<string> LFruits = from fruit in fruits where fruit.Substring(0, 1) == "L" select fruit;

            // foreach (string fruit in LFruits)
            // {
            //     Console.WriteLine(fruit);
            // }

            // // Which of the following numbers are multiples of 4 or 6
            // // List<int> numbers = new List<int>()
            // // {
            // //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // // };

            // // IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0);

            // // foreach (int number in fourSixMultiples)
            // // {
            // //     Console.WriteLine(number);
            // // }

            // // Order these student names alphabetically, in descending order (Z to A)
            // List<string> names = new List<string>()
            // {
            //     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            //     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            //     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            //     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            //     "Francisco", "Tre"
            // };

            // List<string> nameListDescended = names.OrderByDescending(name => name).ToList();
            // foreach (string name in nameListDescended)
            // {
            //     Console.WriteLine(name);
            // }

            // // Build a collection of these numbers sorted in ascending order
            // List<int> numbers = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            // List<int> numbersSortedAscending = numbers.OrderBy(n => n).ToList();
            // foreach (int n in numbersSortedAscending)
            // {
            //     Console.WriteLine(n);
            // }

            // Output how many numbers are in this list
            // List<int> numbers = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // };

            // int numberCount = numbers.Count();
            // Console.WriteLine(numberCount);

            // How much money have we made?

            // List<double> purchases = new List<double>()
            // {
            //     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            // };

            // double sumOfPurchases = purchases.Sum();
            // Console.WriteLine(sumOfPurchases);

            // What is our most expensive product?
            // List<double> prices = new List<double>()
            // {
            //     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            // };

            // double mostExpensiveProduct = prices.Max();
            // Console.WriteLine(mostExpensiveProduct);


            // Store each number in the following List until a perfect square
            // is detected.

            // Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx


            // List<int> wheresSquaredo = new List<int>()
            // {
            //     66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            // };

            // List<int> squareRootList = new List<int>();


            // foreach (int number in wheresSquaredo)

            // {
            //     if (
            //     Math.Sqrt(number) % 1 == 0
            //     )
            //     {
            //         squareRootList.Add(number);
            //     }
            // }
            // foreach (int n in squareRootList)
            // {
            //     Console.WriteLine(n);
            // }

            // Build a collection of customers who are millionaires



        }
    }
}
