using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;

namespace EasySave
{
	class View
	{
        public void Start()
        {
            string prompt = "Welcome to EasySave 1.0. Save what you want where you want ..";
            string[] options = { "Move your folder", "Languages", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            mainMenu.DisplayOptions();
            WriteLine("Press Enter to exit...");
           
            ConsoleKeyInfo keyPressed = ReadKey();
            if (keyPressed.Key == ConsoleKey.Enter)
            {
                WriteLine("You pressed ENTER");
            }
            else
            {
                WriteLine("You pressed another key");
            }

            
            ReadKey(true);
        }
    }
}
