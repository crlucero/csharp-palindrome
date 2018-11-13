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
        char[] Reversed = new char[Letters.Length];

        int j = 0;
        
        for(int i = Letters.Length -1; i >=0; i--)
        {
            Reversed[j] = Letters[i];
            j++;
        }

        string WordReversed = new string(Reversed);
        Console.WriteLine(WordReversed);

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