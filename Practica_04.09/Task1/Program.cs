using System;
using System.IO;
using static System.Console;

namespace Task1
{
    class Program
    {
        //1.	Написать программу, читающую побайтно заданный файл и подсчитывающую число появлений каждого из 256 возможных знаков.
        static void Main(string[] args)
        {
            using (FileStream stream =new FileStream(@"C:\data\1.txt",FileMode.OpenOrCreate))
            {
                byte[] bytes = new byte[stream.Length];
                //stream.Write(bytes, 0, bytes.Length);
                string symbol = System.Text.Encoding.Unicode.GetString(bytes);
                int[] signs = new int[256];

                for (int i=0; i< symbol.Length; i++)
                {
                    signs[symbol[i]]++;
                }
                OutputEncoding = System.Text.Encoding.Unicode;
                WriteLine("символ - количество");
                for (int i=0; i<256; i++)
                {
                    WriteLine((char)i + "=" + signs[i]);                    
                }
                ReadLine();
            }            
        }
    }
}