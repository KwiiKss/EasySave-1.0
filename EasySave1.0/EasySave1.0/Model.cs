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
    public class Json
    {
        public String Name { get; set; }
        public String FileSource { get; set; }
        public String FileTarget { get; set; }
        public String DestPath { get; set; }
        public float FileSize { get; set; }
        public long FileTransferTime { get; set; }
        public String Time { get; set; }
    }

    class Model
    {
        public void Move(string json, string name)
        {
            string path = name;
            if (!File.Exists(path))
            {
                try
                {
                    // Create the file, or overwrite if the file exists.
                    using (FileStream fs = File.Create(path))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(json);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }

                    // Open the stream and read it back.
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else
            {
                File.Delete(path);
                try
                {
                    // Create the file, or overwrite if the file exists.
                    using (FileStream fs = File.Create(path))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(json);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }

                    // Open the stream and read it back.
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                try
                {
                    // Create the file, or overwrite if the file exists.
                    using (FileStream fs = File.Create(path))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(json);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }

                    // Open the stream and read it back.
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
        }
        public static void MoveFile() // Method that moves a file form a source folder to a destination folder
        {
            Console.WriteLine("Enter your file with his type (ex : kilyion.txt):");
            string file = Console.ReadLine();
            Console.WriteLine("Enter the source of your file:");
            string source = Console.ReadLine();
            Console.WriteLine("Enter the destination of your file:");
            string dest = Console.ReadLine();

            string sourceFileName = @"C:\Users\kilyion\source\repos\" + source + "\\" + file + "";
            string destFileName = @"C:\Users\kilyion\source\repos\" + dest + "\\" + file + "";
            File.Move(sourceFileName, destFileName);
            WriteLine("\n\nPress any key to return to the menu...");
            ReadKey(true);
            ViewEN.RunMainMenuEN();
        }
        public static void MoveFolder()  // Method that moves a folder form a source folder to a destination folder
        {
            Console.WriteLine("Enter your folder name:");
            string folder = Console.ReadLine();
            Console.WriteLine("Enter the source of your folder:");
            string source = Console.ReadLine();
            Console.WriteLine("Enter the destination of your folder:");
            string dest = Console.ReadLine();


            string sourceFolderName = @"C:\Users\kilyion\source\repos\" + source + "\\" + folder + "";
            string destFolderName = @"C:\Users\kilyion\source\repos\" + dest + "\\" + folder + "";
            Directory.Move(sourceFolderName, destFolderName);
            WriteLine("\n\nPress any key to return to the menu...");
            ReadKey(true);
            ViewEN.RunMainMenuEN();
        }
        public static void DeplacerFichier() // Méthode qui déplace un fichier d'un dossier source à un dossier destination
        {
            Console.WriteLine("Entrez le nom du fichier avec son type (ex : kilyion.txt):");
            string fichier = Console.ReadLine();
            Console.WriteLine("Entrez la source du fichier:");
            string source = Console.ReadLine();
            Console.WriteLine("Entrez la destination du fichier:");
            string dest = Console.ReadLine();

            string sourceFileName = @"C:\Users\kilyion\source\repos\" + source + "\\" + fichier + "";
            string destFileName = @"C:\Users\kilyion\source\repos\" + dest + "\\" + fichier + "";
            File.Move(sourceFileName, destFileName);
            WriteLine("\n\nAppuyez sur n'importe quel bouton pour revenir au menu...");
            ReadKey(true);
            ViewEN.RunMainMenuEN();
        }
        public static void DeplacerDossier()  // Méthode qui déplace un dossier ainsi que son contenu d'une source à une destination
        {
            Console.WriteLine("Entrez le nom du dossier :");
            string dossier = Console.ReadLine();
            Console.WriteLine("Entrez la source du dossier:");
            string source = Console.ReadLine();
            Console.WriteLine("Entrez la destination du dossier:");
            string dest = Console.ReadLine();


            string sourceFolderName = @"C:\Users\kilyion\source\repos\" + source + "\\" + dossier + "";
            string destFolderName = @"C:\Users\kilyion\source\repos\" + dest + "\\" + dossier + "";
            Directory.Move(sourceFolderName, destFolderName);
            WriteLine("\n\nAppuyez sur n'importe quel bouton pour revenir au menu...");
            ReadKey(true);
            ViewEN.RunMainMenuEN();
        }
    }
}