using System;
using System.Collections.Generic;
using System.Text;

namespace Project_test
{
    class View
    {
        public int language;
        public void Lunch() 
        {
            Console.WriteLine("------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("| choice Language |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("| 1.French        |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("| 2.English       |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------");
            this.language = int.Parse(Console.ReadLine());
            if ( language == 1)
            {

            }
        }
    }
}
