using System;

namespace FindMaxInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Kích thước Matrix
                System.Console.WriteLine("Enter row: ");
                int rows = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Enter collum: ");
                int cols = int.Parse(Console.ReadLine());

                // Tạo Matrix
                int[,] matrix = new int[rows, cols];

                // Nhập giá trị cho Matrix 
                for (int i = 0; i < rows; i++)
                {
                    for (int a = 0; a < cols; a++)
                    {
                        System.Console.WriteLine("Enter element [{0}, {1}]: ", i, a);
                        matrix[i, a] = int.Parse(Console.ReadLine());
                    }
                }

                // Find Max
                int maxValue = matrix[0, 0];
                int rowMax = 0;
                int colMax = 0;

                for (int i = 0; i < rows; i++)
                {
                    for (int a = 0; a < cols; a++)
                    {
                        if (matrix[i, a] > maxValue)
                        {
                            maxValue = matrix[i, a];
                            rowMax = i;
                            colMax = a;
                        }
                    }
                }

                System.Console.WriteLine("Max element: {0}", maxValue);
                System.Console.WriteLine("Position: ({0}, {1})", rowMax, colMax);
            }
        }
    }
}