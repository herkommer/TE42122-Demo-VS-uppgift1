using System;

namespace Uppgifter_20210902
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mina uppgifter:");

            //Uppgift A - HAPPY PATH!!
            //Lagar data, deklarera variabler
            int amount_of_questions = 5;
            string[] food = new string[amount_of_questions];

            //Ställ frågor ett antal gånger
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine("Ange en maträtt: ");
                food[i] = Console.ReadLine();
            }

            //Skriv ut alla maträtterna på samma rad
            for (int i = 0; i < food.Length; i++)
            {
                Console.Write(food[i] + " ");
            }

            Console.WriteLine();

            //Skriv ut alla maträtterna med antal tecken, en per rad
            for (int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i] + " (" + food[i].Length + ")");
            }

            //Hur hittar jag den längsta maträtten?
            //hmm...
            string longest_food = food[0];

            //if (food[0].Length < food[1].Length)
            //{
            //    longest_food = food[1];
            //}

            //if (food[1].Length < food[2].Length)
            //{
            //    longest_food = food[2];
            //}

            for (int i = 0; i < food.Length-1; i++)
            {
                if (food[i].Length < food[i+1].Length)
                {
                    longest_food = food[i + 1];
                }
            }
            

            Console.WriteLine("Longest food: " + longest_food);

            Console.ReadLine();

        }
    }
}
