﻿// See https://aka.ms/new-console-template for more information
namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! from Develop branch");
        StringBasics stringBasics = new StringBasics();
        stringBasics.Interpolation();
    }
}