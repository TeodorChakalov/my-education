using System;

namespace _1.Blank_Receipt
{
    class Program
    {
        static void printReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void printReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void printReceiptFooter()
        {
            string symbol = "\u00A9";
            Console.WriteLine("------------------------------");
            Console.WriteLine("{0} SoftUni", symbol);
        }
        static void Main(string[] args)
        {
            printReceiptHeader();
            printReceiptBody();
            printReceiptFooter();
        }
    }
}