using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _27_6_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //task 1
            // 1 
            string[] arrayy = { "1", " 7", "9", "45" };

            //2
            string[] arr2 = { "Strr", "alex", "moh" };

            //3
            string[] arr3 = { "the", "fox", "over", "lazy", "do" };

            //  task2
            string[] fruits = { "Tomato", "Banana", "Watermelon" };
            int Banan = 0;
            int Tomato = 0;
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == "Banana")
                {
                    Banan = i;
                }
                if (fruits[i] == "Tomato")
                {
                    Tomato = i;
                }
            }
            Console.WriteLine("The Index Of Banana : " + Banan);
            Console.WriteLine("The Index Of Tomato : " + Tomato);


            // task 3


            string[] food = { "Mansaf", " Burger", "Maqlupa ", "pizza", "pasta" };
            string[] sports = { "vollyball", "football", "basketball", "tinnes", "balling" };
            string[] movies = { " fast cars ", " GOT", " harry boter ", " Inception" };

            Console.WriteLine("food");
            foreach (string favoritefoood in food)
            {
                Console.WriteLine(favoritefoood);
            }
            Console.WriteLine("sports");
            foreach (string sportsfoood in sports)
            {
                Console.WriteLine(sportsfoood);
            }
            Console.WriteLine("movies");
            foreach (string moviesfoood in movies)
            {
                Console.WriteLine(moviesfoood);
            }

            // task 4
            Console.WriteLine("Enter 3 numbers separated by , ");
            string num = Console.ReadLine();
            string[] numbers = num.Split(',');
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                sum += int.Parse(numbers[i]);

            }
            Console.WriteLine("The sum of the 3 numbers :" + sum);


            // task 5
            int upperLimit = 100;
            Console.Write("Enter the number of term(n) :");
            int n = int.Parse(Console.ReadLine());
            int summ = 0;
            int count = 0;
            Console.WriteLine($"The first {n} odd numbers are:");
            for (int i = 1; i <= upperLimit; i += 2)
            {
                Console.WriteLine(i + " ");
                summ += i;
                count++;
                if (count == n)
                    break;
                Console.WriteLine($"\n\nThe sum of the first {n} odd numbers is: {sum}");
                Console.ReadLine();


            }

            // task 6
            int raws = 7;
            for (int i = 0; i < raws; i++)
            {
                for (int s = 0; s < raws - i; s++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //task 7
            Console.WriteLine("");

            int numc = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(numc + " ");
                    numc++;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}



