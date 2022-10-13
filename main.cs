// Created by: sophie
// Created on: oct 2020
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int streetNumber;
        string streetName;

        Console.WriteLine("This program gets a user's address");
        Console.WriteLine("");

        Console.Write("Enter your street number: ");
        streetNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your street name: ");
        streetName = Console.ReadLine();

        Console.WriteLine("");
        Console.WriteLine("Your street address is: " +  streetNumber + " " +streetName + ".");
        Console.WriteLine("run while you still can.");

        Console.WriteLine("\nDone.");
    }
}