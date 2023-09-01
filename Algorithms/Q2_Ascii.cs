using System;
using System.Text;

namespace Algorithms
{
    public class Q2_Ascii
    {
        public static string CreateStaircase(int height, int width)
        {
            if (height <= 0 || width <= 0)
            {
                return "";
            }

            StringBuilder staircase = new StringBuilder();

            for (int i = 1; i <= height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    for (int k = 0; k < i; k++)
                    {
                        staircase.Append(" # ");
                    }
                    staircase.AppendLine();
                }
            }

            return staircase.ToString();
        }

        public static void Main_Staircase(string[] args)
        {
            int height = 5;
            int width = 2;
            string result = CreateStaircase(height, width);
            Console.WriteLine(result);
        }
    }
}
