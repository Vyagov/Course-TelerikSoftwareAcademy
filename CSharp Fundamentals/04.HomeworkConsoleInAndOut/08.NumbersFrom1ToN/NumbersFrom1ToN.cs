﻿using System;

// Write a program that reads an integer number N from the console and 
// prints all the numbers in the interval [1, n], each on a single line.

class NumbersFrom1ToN
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numN; i++)
        {
            Console.WriteLine(i);
        }
    }
}
