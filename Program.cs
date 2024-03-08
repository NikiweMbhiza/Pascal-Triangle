using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of rows for Pascal's Triangle:");
            if (int.TryParse(Console.ReadLine(), out int rows) && rows > 0)
            {
                PrintPascalsTriangle(rows);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a positive integer.");
            }

            Console.ReadKey();
        }
        static void PrintPascalsTriangle(int numberOfRows)
        {
            for (int row = 0; row < numberOfRows; row++)
            {
                // Print leading spaces
                for (int space = 0; space < numberOfRows - row - 1; space++)
                {
                    Console.Write(" ");
                }

                // Calculate and print the values in the row
                int value = 1;
                for (int col = 0; col <= row; col++)
                {
                    Console.Write(value + " ");
                    value = value * (row - col) / (col + 1);
                }
                Console.WriteLine();
            }
        }
    }
}
