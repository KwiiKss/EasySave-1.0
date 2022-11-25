using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Diagnostics;
using System.Threading;
using System.Text.Json.Serialization;
using static System.Console;

namespace EasySave
{
    class Model
    {
        public static void CreateFolder()
        {
            Console.Clear();
            Console.WriteLine("Enter the name of the folder :");
            string folderName = Console.ReadLine();
            Console.WriteLine("Enter the folder save path :");
            string destFolder = Console.ReadLine();
            string destFolderName = destFolder + "\\" + folderName + "";

            // If directory does not exist, create it
            if (!Directory.Exists(destFolderName))
            {
                Directory.CreateDirectory(destFolderName);
            }

            WriteLine("\n\nPress any key to return to the menu...");
            ReadKey(true);
            ViewEN.RunMainMenuEN();
        }

        public static void CreerDossier()
        {
            Console.Clear();
            Console.WriteLine("Entrez le nom du dossier :");
            string folderName = Console.ReadLine();
            Console.WriteLine("Entrez le chemin de sauvegarde du dossier :");
            string destFolder = Console.ReadLine();
            string destFolderName = destFolder + "\\" + folderName + "";

            // If directory does not exist, create it
            if (!Directory.Exists(destFolderName))
            {
                Directory.CreateDirectory(destFolderName);
            }

            WriteLine("\n\nAppuyez sur n'importe quelle touche pour revenir au menu...");
            ReadKey(true);
            ViewFR.RunMainMenuFR();
        }

        public static void ShowFolders() // Method that allow the user to check a list of all the files or folder in a searched folder
        {
            Console.Clear();
            Console.WriteLine("Enter the path and the name of the folder:");
            string nomCheminDossier = Console.ReadLine();
            string[] cheminDossier = Directory.GetFileSystemEntries(nomCheminDossier);
            Console.Clear();
            foreach (string Dossier in cheminDossier) //check if there's an other file or folder if found at least one before
                Console.WriteLine(Dossier);
            WriteLine("\n\nPress any key to return to the menu...");
            ReadKey(true);
            ViewEN.RunMainMenuEN();
        }

        public static void MontrerDossiers() // Methode qui permet de récuperer un list de tout les 
        {
            Console.Clear();
            Console.WriteLine("Entrez le chemin ainsi que le nom du dossier :");
            string pathFolderName = Console.ReadLine();
            string[] pathFolder = Directory.GetFileSystemEntries(pathFolderName);
            Console.Clear();
            foreach (string Folder in pathFolder) // vérifie s'il y a un autre fichier ou un autre dossier après en avoir trouvé un
                Console.WriteLine(Folder);
            WriteLine("\n\nAppuyez sur n'importe quelle touche pour revenir au menu...");
            ReadKey(true);
            ViewFR.RunMainMenuFR();
        }

        public static void MoveFile() // Method that moves a file form a source folder to a destination folder
        {
            Console.Clear();

            Console.WriteLine("Enter your file with his type (ex : kilyion.txt) :");
            string file = Console.ReadLine();
            Console.WriteLine("Enter the source of your file:");
            string source = Console.ReadLine();
            string sourceFileName = source + "\\" + file + "";
            Console.WriteLine("Enter the destination of your file :");
            string dest = Console.ReadLine();
            string destFileName = dest + "\\" + file + "";

            File.Move(sourceFileName, destFileName);
            WriteLine($"\n-> The file moved in {destFileName}.");
            WriteLine("\n\nPress any key to return to the menu...");

            ReadKey(true);
            ViewEN.RunMainMenuEN();
        }

        public static void MoveFolder()  // Method that moves a folder form a source folder to a destination folder
        {
            Console.Clear();

            Console.WriteLine("Enter your folder name :");
            string folder = Console.ReadLine();
            Console.WriteLine("Enter the source of your folder :");
            string source = Console.ReadLine();
            string sourceFolderName = source + "\\" + folder + "";
            Console.WriteLine("Enter the destination of your folder :");
            string dest = Console.ReadLine();
            string destFolderName = dest + "\\" + folder + "";

            Directory.Move(sourceFolderName, destFolderName);
            WriteLine($"\n-> The folder moved in {destFolderName}.");
            WriteLine("\n\nPress any key to return to the menu...");

            ReadKey(true);
            ViewEN.RunMainMenuEN();
        }

        public static void DeplacerFichier() // Méthode qui déplace un fichier d'un dossier source à un dossier destination
        {
            Console.Clear();

            Console.WriteLine("Entrez le nom du fichier avec son type (ex : kilyion.txt) :");
            string file = Console.ReadLine();
            Console.WriteLine("Entrez la source du fichier:");
            string source = Console.ReadLine();
            string sourceFileName = source + "\\" + file + "";
            Console.WriteLine("Entrez la destination du fichier :");
            string dest = Console.ReadLine();
            string destFileName = dest + "\\" + file + "";

            File.Move(sourceFileName, destFileName);
            WriteLine($"\n-> Le fichier a bien été déplacé dans {destFileName}.");
            WriteLine("\n\nAppuyez sur n'importe quelle touche pour revenir au menu...");

            ReadKey(true);
            ViewFR.RunMainMenuFR();
        }
        public static void DeplacerDossier()  // Méthode qui déplace un dossier ainsi que son contenu d'une source à une destination
        {
            Console.Clear();

            Console.WriteLine("Entrez le nom du dossier :");
            string folder = Console.ReadLine();
            Console.WriteLine("Entrez la source du dossier:");
            string source = Console.ReadLine();
            string sourceFolderName = source + "\\" + folder + "";
            Console.WriteLine("Entrez la destination du dossier :");
            string dest = Console.ReadLine();
            string destFolderName = dest + "\\" + folder + "";

            Directory.Move(sourceFolderName, destFolderName);
            WriteLine($"\n-> Le dossier a bien été déplacé dans {destFolderName}.");
            WriteLine("\n\nAppuyez sur n'importe quelle touche pour revenir au menu...");

            ReadKey(true);
            ViewFR.RunMainMenuFR();
        }
    }
}