using System;

namespace numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            #region first  minimum number
            int min = 0;
            Console.Write("Enter the length of your array, please");
            int n = Convert.ToInt16(Console.ReadLine());
            int [] a = new int[n];  
            Console.WriteLine("Enter your numbers, please");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt16(Console.ReadLine());
             }
            for (int i = 0; i < n; i++) 
            {
                min = a[0];
                if (a[i] < min)
                {
                    min = a[i];
                    break;
                }
            }
            Console.WriteLine(min);
            Console.ReadLine();
            #endregion

            {

            }

        }
    }
}
