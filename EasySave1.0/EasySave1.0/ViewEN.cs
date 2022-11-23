using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Console;

namespace EasySave
{
    // Menu en anglais
    class ViewEN
    {
        public void Start()
        {
            Title = "EasySave - Backup SoftWare";
            RunMainMenuEN();
        }

        public static void RunMainMenuEN()
        {
            string prompt = @"
███████╗ █████╗ ███████╗██╗   ██╗███████╗ █████╗ ██╗   ██╗███████╗     ██╗    ██████╗ 
██╔════╝██╔══██╗██╔════╝╚██╗ ██╔╝██╔════╝██╔══██╗██║   ██║██╔════╝    ███║   ██╔═████╗
█████╗  ███████║███████╗ ╚████╔╝ ███████╗███████║██║   ██║█████╗      ╚██║   ██║██╔██║
██╔══╝  ██╔══██║╚════██║  ╚██╔╝  ╚════██║██╔══██║╚██╗ ██╔╝██╔══╝       ██║   ████╔╝██║
███████╗██║  ██║███████║   ██║   ███████║██║  ██║ ╚████╔╝ ███████╗     ██║██╗╚██████╔╝  
╚══════╝╚═╝  ╚═╝╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝  ╚═══╝  ╚══════╝     ╚═╝╚═╝ ╚═════╝   by ProSoft.  

                                                                                      
Welcome to EasySave 1.0. Save what you want where you want ..


Use the arrows in order to select your choice.
";
            string[] options = { "Move your file", "Move your folder", "Change the language in french", "About us", "Exit" };
            MenuEN mainMenu = new MenuEN(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    ViewEN.MoveFile();
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

        private static void MoveFile()
        {

        }

        private static void MoveFolder()
        {

        }

        private static void Languages()
        {
            ViewFR.RunMainMenuFR();
        }

        private static void DisplayAboutUs()
        {
            Console.Clear();
            WriteLine("");
            WriteLine("The Easy Save software was developed by ProSoft in November 2022.");
            WriteLine("\nThe team responsible for this project is composed of Kévin LAURENT, Kilyion ROMARY, Hugo CORSO and Nicolas FOUQUE.");
            WriteLine("\n© EasySave 2022-2022");
            WriteLine("\n\nPress any key to return to the menu...");
            ReadKey(true);
            RunMainMenuEN();

        }

        private static void Exit()
        {
            Console.Clear();
            WriteLine("Press any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }
    }



    // Menu en français
    class ViewFR
    {
        public void Demarre()
        {
            Title = "EasySave - Logiciel de Sauvegarde";
            RunMainMenuFR();
        }

        public static void RunMainMenuFR()
        {
            string prompt = @"
███████╗ █████╗ ███████╗██╗   ██╗███████╗ █████╗ ██╗   ██╗███████╗     ██╗    ██████╗ 
██╔════╝██╔══██╗██╔════╝╚██╗ ██╔╝██╔════╝██╔══██╗██║   ██║██╔════╝    ███║   ██╔═████╗
█████╗  ███████║███████╗ ╚████╔╝ ███████╗███████║██║   ██║█████╗      ╚██║   ██║██╔██║
██╔══╝  ██╔══██║╚════██║  ╚██╔╝  ╚════██║██╔══██║╚██╗ ██╔╝██╔══╝       ██║   ████╔╝██║
███████╗██║  ██║███████║   ██║   ███████║██║  ██║ ╚████╔╝ ███████╗     ██║██╗╚██████╔╝  
╚══════╝╚═╝  ╚═╝╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝  ╚═══╝  ╚══════╝     ╚═╝╚═╝ ╚═════╝   par ProSoft.  

                                                                                      
Bienvenue dans EasySave 1.0. Sauvegardez ce que vous voulez où vous voulez ..


Utilisez les flèches pour sélectionner votre choix.
";
            string[] options = { "Déplacez votre fichier", "Déplacez votre dossier", "Changez la langue en anglais", "A propos de nous", "Quitter" };
            MenuFR mainMenu = new MenuFR(prompt, options);
            int selectedIndex = mainMenu.Lance();

            switch (selectedIndex)
            {
                case 0:
                    DeplacerFichier();
                    break;
                case 1:
                    DeplacerDossier();
                    break;
                case 2:
                    Langues();
                    break;
                case 3:
                    AffiApropos();
                    break;
                case 4:
                    Quitter();
                    break;
            }
        }

        private static void DeplacerFichier()
        {

        }

        private static void DeplacerDossier()
        {

        }

        private static void Langues()
        {
            ViewEN.RunMainMenuEN();
        }

        private static void AffiApropos()
        {
            Console.Clear();
            WriteLine("");
            WriteLine("L'application de sauvegarde EasySave a été développé en Novembre 2022.");
            WriteLine("\nL'équipe responsable du projet est composée de Kévin LAURENT, Kilyion ROMARY, Hugo CORSO and Nicolas FOUQUE.");
            WriteLine("\n© EasySave 2022-2022");
            WriteLine("\n\nAppuyez sur n'importe quelle touche pour revenir au menu...");
            ReadKey(true);
            RunMainMenuFR();

        }

        private static void Quitter()
        {
            Console.Clear();
            WriteLine("Press any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }
    }
}

