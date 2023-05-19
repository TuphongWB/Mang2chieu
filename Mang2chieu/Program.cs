using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang2chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập kích thước của ma trận (số hàng và số cột):");
            int rows = Convert.ToInt32(Console.ReadLine());
            int columns = Convert.ToInt32(Console.ReadLine());

            double[,] matrix = new double[rows, columns];

            // Nhập giá trị cho ma trận từ người dùng
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Nhập giá trị của phần tử [{0},{1}]: ", i, j);
                    matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.WriteLine("Ma trận đã nhập:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Tìm phần tử lớn nhất và tọa độ
            double maxValue = matrix[0, 0];
            int maxRow = 0;
            int maxColumn = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > maxValue)
                    {
                        maxValue = matrix[i, j];
                        maxRow = i;
                        maxColumn = j;
                    }
                }
            }

            Console.WriteLine("Phần tử lớn nhất trong ma trận là {0} tại tọa độ [{1},{2}]", maxValue, maxRow, maxColumn);
            Console.ReadKey();
        }
    }
}
