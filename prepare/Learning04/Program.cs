using System;
using System.Drawing;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Assignment first = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(first.GetSummary());
    } 
}