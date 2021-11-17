using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ShoppingListAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\Samples\shoppingList";
            string fileName = @"\\myShoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myWishList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Kas soovid midagi ostunimekirja lisada? Kui jah, vajuta '+', kui ei, vajuta '-'");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == '+')
                {
                    Console.WriteLine("Sisesta oma ostusoov:");
                    string userWish = Console.ReadLine();
                    myWishList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Ole tubli!");
                }

            }

            Console.Clear();

            foreach (string wish in myWishList)
            {
                Console.WriteLine($"Sinu ostusoov: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myWishList);

        }
    }
}
