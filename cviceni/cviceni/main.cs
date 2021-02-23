using System;
using System.Collections.Generic;

namespace cviceni
{
    public class Program
    {
    public static void Main(string[] args)
        {     
        double[,] matice1 = new double[,]
            {
            {5,7,4},
            {9,1,6},
            {4,2,7}
            };
        double[,] matice2 = new double[,]
            {
            {7,2,3},
            {3,8,7},
            {7,5,3}
            };
        
        Matrix x1 = new Matrix(matice1);
        Matrix x2 = new Matrix(matice2);

        Console.WriteLine("1. Matice:");
        x1.ToString();
        Console.WriteLine("\n2.Matice: ");
        x2.ToString();
        Console.WriteLine("\nOperace:");
        Console.WriteLine("  ·Soucet (A+B): ");
            Console.WriteLine(x1+x2);
        Console.WriteLine("  ·Rozdil (A-B): ");
            Console.Write(x1-x2 + "\n");
        Console.WriteLine("  ·Soucin (A*B): ");
            Console.Write(x1*x2 + "\n");
        Console.WriteLine("  ·Determinant prvni matice: {0}", x1.determinant());
        Console.WriteLine("  ·Determinant druhe matice: {0}", x2.determinant());
        Console.WriteLine("  ·Shodnost: {0}", x1==x2);
        Console.WriteLine("  ·Rozilnost: {0}", x1!=x2);
        Console.WriteLine("  ·Unarni operator:\n" + "      -Prvni matice:");
            Console.WriteLine(-x1);
        Console.WriteLine("      -Druha matice:");
            Console.WriteLine(-x2);


        }
    }
}
