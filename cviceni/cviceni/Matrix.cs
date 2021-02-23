using System;
using System.Collections.Generic;
using System.Text;

namespace cviceni
{
    class Matrix
    {   
    public double[,] matrix;
    public Matrix(double[,] matice)
        {
        matrix = matice;
        }

    public static Matrix operator +(Matrix a, Matrix b)
        {
        if (a.matrix.GetLength(0) == b.matrix.GetLength(0))
            { 
            if (a.matrix.GetLength(1) == b.matrix.GetLength(1))
                {
                var help = new Matrix(new double[a.matrix.GetLength(0),b.matrix.GetLength(0)]);
                for (int x = 0; x < a.matrix.GetLength(1); ++x)
                    {
                    for (int y = 0; y < b.matrix.GetLength(1); ++y)
                        {
                        help.matrix[x,y] = a.matrix[x,y] + b.matrix[x,y];
                        }
                    }
                return help;
                }
            else
                {
                Console.WriteLine("      Matice nelze secist !");
                return null;
                }
            }
        else
            {
            Console.WriteLine("      Matice nelze secist !");
            return null; 
            }
        }

    public static Matrix operator -(Matrix a, Matrix b)
        {
        if (a.matrix.GetLength(0) == b.matrix.GetLength(0))
            {
            if (a.matrix.GetLength(1) == b.matrix.GetLength(1))
                {
                var help = new Matrix(new double[a.matrix.GetLength(0), b.matrix.GetLength(1)]);
                for (int x = 0; x < a.matrix.GetLength(1); ++x)
                    {
                    for (int y = 0; y < b.matrix.GetLength(1); ++y)
                        {
                        help.matrix[x, y] = a.matrix[x, y] - b.matrix[x, y];
                        }
                    }
                return help;
                }
            else
                {
                Console.WriteLine("      Matice nelze odecist !");
                return null;
                }
            }
        else
            {
            Console.WriteLine("      Matice nelze odecist !");
            return null;
            }

        }

    public static Matrix operator *(Matrix a, Matrix b)
        {
        if (a.matrix.GetLength(0) == b.matrix.GetLength(1)
            && a.matrix.GetLength(1) == b.matrix.GetLength(0))
            {
            var help = new Matrix(new double[a.matrix.GetLength(0), b.matrix.GetLength(1)]);
            
            for(int z = 0; z < a.matrix.GetLength(0); ++z)
                {
                for(int x = 0; x < a.matrix.GetLength(0); ++x)
                    {
                    for (int y = 0; y < b.matrix.GetLength(0);++y)
                        {
                        help.matrix[z,x] += a.matrix[z,y]*b.matrix[y,x];
                        }                    
                    }
                }
                return help;
            }
        else
            {
            Console.WriteLine("      Nelze násobit matice !");
            return null;
            }
        }
    
    public static bool operator ==(Matrix a, Matrix b)
        {
        if (a.matrix.Equals(b.matrix))
            {
            return true;
            }
        else
            {
            return false;
            }
        }

    public static bool operator !=(Matrix a, Matrix b)
        {
        if (!a.matrix.Equals(b))
            {
            return true;
            }
        else
            {
            return false;
            }
        }

    public static Matrix operator -(Matrix a)
        {
        var help = new Matrix(new double[a.matrix.GetLength(0),a.matrix.GetLength(1)]);
        for (int x = 0; x < a.matrix.GetLength(0); ++x)
            {
            for (int y = 0; y < a.matrix.GetLength(1); ++y)
                {
                help.matrix[x,y] = -a.matrix[x,y];
                }
            }
        return help;
        }

    public double determinant()
        {
        if(matrix.GetLength(0) <= 3 && matrix.GetLength(0) == matrix.GetLength(1))
            {
            if (matrix.GetLength(1) <= 3)
                {
                if(matrix.GetLength(0) == 1 && matrix.GetLength(0) == 1)
                    {
                    return matrix[0,0];
                    }
                else if(matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
                    {
                    return matrix[0,0]*matrix[1,1]-matrix[0,1]*matrix[1,0];
                    }
                else
                    {
                    return (matrix[0,0]*matrix[1,1]*matrix[2,2])+(matrix[0,2]*matrix[1,0]*matrix[2,1])+(matrix[0,1]*matrix[1,2]*matrix[2,0])-(matrix[0,2]*matrix[1,1]*matrix[2,0])-(matrix[0,0]*matrix[1,2]*matrix[2,1])-(matrix[0,1]*matrix[1,0]*matrix[2,2]);
                    }
                }
            else
                {
                Console.Write("\n      Nelze vypocist determinant ! Error: ");
                return 0;
                }
            }
        else
            {
            Console.Write("      Nelze vypocist determinant ! Error: ");
            return 1;
            }
        }
    
    public override string ToString()
        {
        for(int x = 0; x < matrix.GetLength(0); ++x)
            {
            Console.Write("       ");
            for (int y = 0; y < matrix.GetLength(1); ++y)
                {
                Console.Write(" {0} ", matrix[x,y]);
                }
            Console.Write("\n");
            }
        return null;
        }



    }
}

