using System;
using System.IO;

namespace HomeWork09._04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = File.ReadAllLines("text.txt");
            for(int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine(array[i]);
                array[i] += array[i];
            }
            string txt = "asd";
            string type = ".txt";
            string tt = txt + type;
            File.WriteAllLines(tt,array);

            Console.ReadKey();
        }
    }
}
