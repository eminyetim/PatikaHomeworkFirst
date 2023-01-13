﻿using System;

namespace algoritma1Patika
{
    class Program
    {
        public static void Main(string[] args)
        {
            Odevler od = new();
            //od.firstHomeWork(); //Cift olanlar yazilir.
            //od.secondHomework(); // M'e esit ya da tam bolunenler
            //od.thirdHomework(); // Tersini sıralar.
            od.FourthHomework();  // Toplam harf ve kelime sayısı.
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

            System.Console.WriteLine("** Result **");
            foreach (var item in arr)
            {
                if(item % 2 == 0)
                {
                    System.Console.WriteLine(item);
                }              
            }
        }

        public void secondHomework()
        {
            int size = 0;
            int[] arr;
            int m = 0;

            System.Console.WriteLine("Please enter the m");
            m = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Please enter the size of array :");
            size = int.Parse(Console.ReadLine());

            arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                System.Console.WriteLine("Please enter the " + (i + 1) + ". index :");
                arr[i] = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("** Result **");
            foreach (var item in arr)
            {
                if(item % m == 0 || item == m)
                {
                    System.Console.WriteLine(item);
                }
            }
        }

        public void thirdHomework()
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
            
            System.Console.WriteLine("** Result **");
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                System.Console.WriteLine(item);
            }


        }

        public void FourthHomework()
        {
            string give_str = Convert.ToString(Console.ReadLine());
            System.Console.WriteLine("** Result **");
            System.Console.WriteLine("Word Count :" + give_str.wordCount());
            System.Console.WriteLine("Letters Count :" + give_str.numbersOfLetters());
             
        }

    }

    public static class Extension
    {
        public static int wordCount(this string str)
        {
            int count = 0;
            int i = 0;
            while(i < str.Length)
            {   
                if(str[i] == ' ')
                    count++;
                i++;
            }
            return ++count;
        }

        public static int numbersOfLetters(this string str)
        {
            int counter = 0;
            int i = 0;
            while(i < str.Length)
            {
                if(str[i] != ' ')
                    counter++;
                i++;
            }
            return counter;
        }
    }
}