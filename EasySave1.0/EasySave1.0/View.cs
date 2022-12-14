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
        public void Start() // Méthode de démarrage de l'application qui affiche l'application en anglais et change le titre de la console
        {
            Title = "EasySave - Backup SoftWare";
            RunMainMenuEN();
        }

        public static void RunMainMenuEN() // Méthode qui affiche tout le menu anglais
        {
            string prompt = @"
███████╗ █████╗ ███████╗██╗   ██╗███████╗ █████╗ ██╗   ██╗███████╗     ██╗    ██████╗ 
██╔════╝██╔══██╗██╔════╝╚██╗ ██╔╝██╔════╝██╔══██╗██║   ██║██╔════╝    ███║   ██╔═████╗
█████╗  ███████║███████╗ ╚████╔╝ ███████╗███████║██║   ██║█████╗      ╚██║   ██║██╔██║
██╔══╝  ██╔══██║╚════██║  ╚██╔╝  ╚════██║██╔══██║╚██╗ ██╔╝██╔══╝       ██║   ████╔╝██║
███████╗██║  ██║███████║   ██║   ███████║██║  ██║ ╚████╔╝ ███████╗     ██║██╗╚██████╔╝  
╚══════╝╚═╝  ╚═╝╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝  ╚═══╝  ╚══════╝     ╚═╝╚═╝ ╚═════╝   by ProSoft.  

                                                                                      
Welcome to EasySave 1.0. Save what you want where you want ..


Use the arrows in order to select your choice.";
            string[] options = { "Create a folder", "Show created folders", "Move your file", "Move your folder", "Change the language in french", "About us", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Select();

            switch (selectedIndex)
            {
                case 0:
                    CreateFolder();
                    break;
                case 1:
                    ShowFolders();
                    break;
                case 2:
                    MoveFile();
                    break;
                case 3:
                    MoveFolder();
                    break;
                case 4:
                    Languages();
                    break;
                case 5:
                    DisplayAboutUs();
                    break;
                case 6:
                    Exit();
                    break;
            }
        }
        
        private static void CreateFolder()
        {
            Model.CreateFolder();
        }

        private static void ShowFolders()
        {
            Model.ShowFolders();
        }

        private static void MoveFile()
        {
            Model.MoveFile();
        }

        private static void MoveFolder()
        {
            Model.MoveFolder();
        }

        private static void Languages() // Méthode qui affiche la page en français (changement de langue)
        {
            Title = "EasySave - Logiciel de sauvegarde";
            ViewFR.RunMainMenuFR();
        }

        private static void DisplayAboutUs() // Méthode qui affiche la page de "A propos de"
        {
            Console.Clear();
            WriteLine("The Easy Save software was developed by ProSoft in November 2022.");
            WriteLine("The team responsible for this project is composed of Kévin LAURENT, Kilyion ROMARY, Hugo CORSO and Nicolas FOUQUE.");
            WriteLine("\n© EasySave 2022-2022");
            WriteLine("\n\nPress any key to return to the menu...");
            ReadKey(true);
            RunMainMenuEN();

        }

        private static void Exit() // Méthode qui affiche la page "Exit" et quitte l'application si une touche est pressée
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

        public static void RunMainMenuFR() // Méthode qui affiche tout le menu en français
        {
            string prompt = @"
███████╗ █████╗ ███████╗██╗   ██╗███████╗ █████╗ ██╗   ██╗███████╗     ██╗    ██████╗ 
██╔════╝██╔══██╗██╔════╝╚██╗ ██╔╝██╔════╝██╔══██╗██║   ██║██╔════╝    ███║   ██╔═████╗
█████╗  ███████║███████╗ ╚████╔╝ ███████╗███████║██║   ██║█████╗      ╚██║   ██║██╔██║
██╔══╝  ██╔══██║╚════██║  ╚██╔╝  ╚════██║██╔══██║╚██╗ ██╔╝██╔══╝       ██║   ████╔╝██║
███████╗██║  ██║███████║   ██║   ███████║██║  ██║ ╚████╔╝ ███████╗     ██║██╗╚██████╔╝  
╚══════╝╚═╝  ╚═╝╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝  ╚═══╝  ╚══════╝     ╚═╝╚═╝ ╚═════╝   par ProSoft.  

                                                                                      
Bienvenue dans EasySave 1.0. Sauvegardez ce que vous voulez où vous voulez ..


Utilisez les flèches pour sélectionner votre choix.";
            string[] options = { "Créez un dossier", "Voir les dossiers créés", "Déplacez votre fichier", "Déplacez votre dossier", "Changez la langue en anglais", "A propos de nous", "Quitter" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Select();

            switch (selectedIndex)
            {
                case 0:
                    CréerDossier();
                    break;
                case 1:
                    MontrerDossiers();
                    break;
                case 2:
                    DeplacerFichier();
                    break;
                case 3:
                    DeplacerDossier();
                    break;
                case 4:
                    Langues();
                    break;
                case 5:
                    AffiApropos();
                    break;
                case 6:
                    Quitter();
                    break;
            }
        }

        private static void CréerDossier()
        {
            Model.CreerDossier();
        }
        private static void MontrerDossiers()
        {
            Model.MontrerDossiers();
        }

        private static void DeplacerFichier()
        {
            Model.DeplacerFichier();
        }

        private static void DeplacerDossier()
        {
            Model.DeplacerDossier();
        }

        private static void Langues() // Méthode qui affiche la page en anglais (changement de langue)
        {
            Title = "EasySave - Backup Software";
            ViewEN.RunMainMenuEN();
        }

        private static void AffiApropos() // Méthode qui affiche la page de "A propos de"
        {
            Console.Clear();
            WriteLine("L'application de sauvegarde EasySave a été développé en Novembre 2022.");
            WriteLine("L'équipe responsable du projet est composée de Kévin LAURENT, Kilyion ROMARY, Hugo CORSO and Nicolas FOUQUE.");
            WriteLine("\n© EasySave 2022-2022");
            WriteLine("\n\nAppuyez sur n'importe quelle touche pour revenir au menu...");
            ReadKey(true);
            RunMainMenuFR();
        }

        private static void Quitter() // Méthode qui affiche la page "Quitter" et quitte l'application si une touche est pressée
        {
            Console.Clear();
            WriteLine("Appuyez sur une touche pour quitter...");
            ReadKey(true);
            Environment.Exit(0);
        }
    }
}