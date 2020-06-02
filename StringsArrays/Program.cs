using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace StringsArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // ***********************  Strings  ***************************************
            
            // Split - separates a given string into smaller pieces, according to chosen separators
            string names = "Peter, John; Andy,, David";

            string[] separator = {",",";"}; // Defines the separator to be used for splitting the string

            string[] substrings = names.Split(separator, StringSplitOptions.None); // Splits the string
            
            foreach (var word in substrings)
            {
                Console.Write(word);
            }
            
            // Length - returns amount of characters in the string
            Console.WriteLine($"\nQuantidade de caracteres na string 'names': {names.Length}");
            
            // Substring - extracts a substring from a larger string
            string newNames = names.Substring(7, 4);
            Console.WriteLine($"\nSubstring da string 'names': {newNames}");
            
            // Equals - returns true if 2 strings are exactly the same
            Console.WriteLine($"\nAre names and newNames equal: {names.Equals(newNames)}");
            
            // ****************************************  Lists  *********************************
            
            // Array - type of list which can only hold a definite number of items
            int[] myArray = new int[10]; // Creates an Array of integers with length of 10 (indexes start at 0)
            
            // List - type of list to which values can be added or removed at will
            List<int> myList = new List<int> {11, 21, 31, 41}; // Creates a list with given integers
            Console.WriteLine($"\nPrimeiro elemento da lista [11, 21, 31, 41] é: {myList[0]}");
            
            // List Methods
            
            // Add() - Adds item to the end of the list
            myList.Add(51);
            myList.ForEach(Console.WriteLine);
            
            // Count - returns the number of elements in a list
            Console.WriteLine($"Quantidade de elementos na lista: {myList.Count}");
            
            // Insert - inserts item at a specific position
            Console.WriteLine("\nInsert: ");
            myList.Insert(2, 44);
            myList.ForEach(Console.WriteLine);
            
            // Remove - removes specified item from list. Removes only the first occurrence
            Console.WriteLine("\nRemove:");
            myList.Remove(44);
            myList.ForEach(Console.WriteLine);
            
            // RemoveAt - removes item at the specified index
            Console.WriteLine("\nRemoveAt: ");
            myList.RemoveAt(0);
            myList.ForEach(Console.WriteLine);
            
            // Contains() - checks if a list contains the specified item
            Console.WriteLine("\nContains(): ");
            Console.WriteLine(myList.Contains(41));
            
            // Clear -  removes all elements from a list
            Console.WriteLine("\nClear(): ");
            myList.Clear();
            myList.ForEach(Console.WriteLine);
            Console.WriteLine("\nPrints nothing because the list is now empty");
            
            Console.WriteLine("\nDigite seu nome: ");
            var userName = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            var userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nome do usuário é {0} e sua idade é {1}", userName, userAge);
            Console.WriteLine("Somando 3 à sua idade obteremos: {0}", userAge + 3);


        }
    }
}