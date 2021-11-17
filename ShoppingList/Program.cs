using System;
using System.IO;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            //kausta nimi shopping list
            //faili nimi myshoppinglist.txt

            string rootDirectory = @"C:\Users\Kristian\Desktop\Programmeerimise algkursus\Samples";
            Console.WriteLine("Sisesta kausta nimi 'shoppingList'");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Sisesta faili nimi: 'myShoppingList.txt");
            string fileName = Console.ReadLine();


            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory and file exist.");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }
        }
    }
}
