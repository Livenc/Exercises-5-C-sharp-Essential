using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class MyMatrix
    {
        //public int Height { get; set; }
        //public int Wight { get; set; }
        //int[,] matrix;
        //public MyMatrix(int height, int width)
        //{
        //    Height = height;
        //    Wight = width;
        //}
        int height, width;
        public void SetupMatrix()
        {
            do
            {
                Console.Write("input hight : ");
                if (!Int32.TryParse(Console.ReadLine(), out  height))
                {
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
                Console.Clear();

            } while (true);
            do
            {
                Console.Write("Input width : ");
                if (!Int32.TryParse(Console.ReadLine(), out  width))
                {
                    Console.WriteLine();
                }
                else
                {
                    break;
                }
                Console.Clear();
            } while (true);
            ShowMatrix(height, width);
        }
         void ShowMatrix(int height, int width)
        {
           
            //  matrix= new int[Height, Wight];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
            }

        }
    }
}
