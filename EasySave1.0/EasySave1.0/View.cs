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
            Title = "EasySave - Backup SoftWare";
            RunMainMenu();
        }

        private void RunMainMenu()
            {
                string prompt = @"
███████╗ █████╗ ███████╗██╗   ██╗███████╗ █████╗ ██╗   ██╗███████╗     ██╗    ██████╗ 
██╔════╝██╔══██╗██╔════╝╚██╗ ██╔╝██╔════╝██╔══██╗██║   ██║██╔════╝    ███║   ██╔═████╗
█████╗  ███████║███████╗ ╚████╔╝ ███████╗███████║██║   ██║█████╗      ╚██║   ██║██╔██║
██╔══╝  ██╔══██║╚════██║  ╚██╔╝  ╚════██║██╔══██║╚██╗ ██╔╝██╔══╝       ██║   ████╔╝██║
███████╗██║  ██║███████║   ██║   ███████║██║  ██║ ╚████╔╝ ███████╗     ██║██╗╚██████╔╝  
╚══════╝╚═╝  ╚═╝╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝  ╚═══╝  ╚══════╝     ╚═╝╚═╝ ╚═════╝   by ProSoft.  

                                                                                      
Welcome to EasySave 1.0, Save what you want where you want ..


Use the arrows in order to select.
";
                string[] options = { "Move your file", "Move your folder", "Languages", "About us", "Exit" };
                Menu mainMenu = new Menu(prompt, options);
                int selectedIndex = mainMenu.Run();
                
                switch (selectedIndex)
                {
                    case 0:
                        MoveFile();
                        break;
                    case 1:
                        MoveFolder();
                        break;
                    case 2:
                        Languages();
                        break;
                    case 3:
                        DisplayAboutUs();
                        break;
                    case 4:
                        Exit();
                        break;
                }
            }

        private void MoveFile()
        {

        }

        private void MoveFolder()
        {

        }

        private void Languages()
        {

        }


        private void DisplayAboutUs()
        {

        }

        private void Exit()
        {
            Console.Clear();
            WriteLine("Press any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }
    }
}
