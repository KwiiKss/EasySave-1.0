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
            string prompt = @"
███████╗ █████╗ ███████╗██╗   ██╗███████╗ █████╗ ██╗   ██╗███████╗     ██╗    ██████╗ 
██╔════╝██╔══██╗██╔════╝╚██╗ ██╔╝██╔════╝██╔══██╗██║   ██║██╔════╝    ███║   ██╔═████╗
█████╗  ███████║███████╗ ╚████╔╝ ███████╗███████║██║   ██║█████╗      ╚██║   ██║██╔██║
██╔══╝  ██╔══██║╚════██║  ╚██╔╝  ╚════██║██╔══██║╚██╗ ██╔╝██╔══╝       ██║   ████╔╝██║
███████╗██║  ██║███████║   ██║   ███████║██║  ██║ ╚████╔╝ ███████╗     ██║██╗╚██████╔╝  
╚══════╝╚═╝  ╚═╝╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝  ╚═══╝  ╚══════╝     ╚═╝╚═╝ ╚═════╝   by ProSoft.  
                                                                                      
Welcome to EasySave 1.0, ''Save what you want where you want ..''";
            string[] options = { "Move your file", "Move your folder", "Languages", "About us", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            WriteLine("Press Enter to exit...");
            ReadKey(true);
        }
    }
}
