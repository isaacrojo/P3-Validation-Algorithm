using System;

namespace Validation_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int uno = 1;

            Console.WriteLine("Inserte cualquier número para comenzar algoritmo");
            int numTyped = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numTyped; i++)
            {
                System.Console.Write(uno + ", ");
            }
            System.Console.Write(numTyped);        
        }
    }
}
