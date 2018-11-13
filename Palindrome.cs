using System;
using System.Collections.Generic;

public class Palindrome {

    public static void Main()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("-----C# Palindrom Checker-----");
        Console.WriteLine("------------------------------");

        Console.WriteLine("Enter a word to check: ");
        string Word = Console.ReadLine();
        char[] Letters = Word.ToCharArray();
        
        Array.Reverse(Letters);
        string WordReversed = new string(Letters);


        if(Word == WordReversed)
        {
            Console.WriteLine("Your word is a palindrome!");
        } 
        else
        {
            Console.WriteLine("Your word is NOT a palindrome!");
        }

    }
}