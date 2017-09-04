using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace task2_1_
{
    //2.	С помощью класса StreamWriter записать в текстовый файл свое имя, фамилию и возраст. Каждая запись должна начинаться с новой строки.
    class Program
    {
        static void Main(string[] args)
        {
            string writePath = @"C:\data\2.txt";

            string name = "Nurtleu";
            string surname = "Omirzhanov";
            int age = 16;

            using (StreamWriter stream = new StreamWriter(writePath, true, System.Text.Encoding.Unicode))
            {   
                stream.WriteLine(name);
                stream.WriteLine(surname);
                stream.WriteLine(age);
            };
        }
    }
}
