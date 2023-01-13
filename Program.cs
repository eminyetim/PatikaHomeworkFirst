using System;

namespace algoritma1Patika
{
    class Program
    {
        public static void Main(string[] args)
        {
            Odevler od = new();
            od.firstHomeWork();
        }
    }

    class Odevler
    {
        public void firstHomeWork()
        {
            int size = 0;
            int[] arr;
            
            System.Console.WriteLine("Please enter the size of array :");
            size = int.Parse(Console.ReadLine());
            
            arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                System.Console.WriteLine("Please enter the " + (i + 1) + ". index :");
                arr[i] = int.Parse(Console.ReadLine());
            }

            foreach (var item in arr)
            {
                if(item % 2 == 0)
                {
                    System.Console.WriteLine(item);
                }              
            }
        }  

    }
}