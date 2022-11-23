using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;

namespace EasySave
{
    class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }
        
        private void DisplayOptions()
        {
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;

                if (i == SelectedIndex)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                    WriteLine($"{prefix} << {currentOption} >>");
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                    WriteLine($"{prefix}  {currentOption} ");
                }
            }
            ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                }

            } while (keyPressed != ConsoleKey.Enter);
            return SelectedIndex;
        }
    }
}