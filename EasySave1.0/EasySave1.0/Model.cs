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

        public static void MoveFile() // Method that moves a file form a source folder to a destination folder
        {
            Model json = new Model();
            var sw = new Stopwatch();
            Console.Clear();
            Console.WriteLine("Enter your file with his type (ex : kilyion.txt):");
            string file = Console.ReadLine();
            Console.WriteLine("Enter the source of your file:");
            string source = Console.ReadLine();
            Console.WriteLine("Enter the destination of your file:");
            string dest = Console.ReadLine();

            string sourceFileName = @"C:\Users\kilyion\source\repos\" + source + "\\" + file + "";
            string destFileName = @"C:\Users\kilyion\source\repos\" + dest + "\\" + file + "";
            FileInfo fInfo = new FileInfo(sourceFileName);
            float size = fInfo.Length;
            sw.Start();
            File.Move(sourceFileName, destFileName);
            sw.Stop();
            string Text = json.SetJson(sourceFileName,destFileName,size,sw.ElapsedMilliseconds);
            json.FileLog(Text);
            WriteLine($"\n-> The file moved in {destFileName}.");
            WriteLine("\n\nPress any key to return to the menu...");
            ReadKey(true);
            ViewEN.RunMainMenuEN();
        }

        public static void MoveFolder()  // Method that moves a folder form a source folder to a destination folder
        {
            Console.Clear();
            Console.WriteLine("Enter your folder name:");
            string folder = Console.ReadLine();
            Console.WriteLine("Enter the source of your folder:");
            string source = Console.ReadLine();
            Console.WriteLine("Enter the destination of your folder:");
            string dest = Console.ReadLine();

            string sourceFolderName = @"C:\Users\kilyion\source\repos\" + source + "\\" + folder + "";
            string destFolderName = @"C:\Users\kilyion\source\repos\" + dest + "\\" + folder + "";
            Directory.Move(sourceFolderName, destFolderName);
            WriteLine($"\n-> The folder moved in {destFolderName}.");
            WriteLine("\n\nPress any key to return to the menu...");
            ReadKey(true);
            ViewEN.RunMainMenuEN();
        }

        public static void DeplacerFichier() // Méthode qui déplace un fichier d'un dossier source à un dossier destination
        {
            Console.Clear();
            Console.WriteLine("Entrez le nom du fichier avec son type (ex : kilyion.txt):");
            string fichier = Console.ReadLine();
            Console.WriteLine("Entrez la source du fichier:");
            string source = Console.ReadLine();
            Console.WriteLine("Entrez la destination du fichier:");
            string dest = Console.ReadLine();

            string sourceFileName = @"C:\Users\kilyion\source\repos\" + source + "\\" + fichier + "";
            string destFileName = @"C:\Users\kilyion\source\repos\" + dest + "\\" + fichier + "";
            File.Move(sourceFileName, destFileName);
            WriteLine($"\n-> Le fichier a bien été déplacé dans {destFileName}.");
            WriteLine("\n\nAppuyez sur n'importe quel bouton pour revenir au menu...");
            ReadKey(true);
            ViewEN.RunMainMenuEN();
        }
        public static void DeplacerDossier()  // Méthode qui déplace un dossier ainsi que son contenu d'une source à une destination
        {

            Console.Clear();
            Console.WriteLine("Entrez le nom du dossier :");
            string dossier = Console.ReadLine();
            Console.WriteLine("Entrez la source du dossier:");
            string source = Console.ReadLine();
            Console.WriteLine("Entrez la destination du dossier:");
            string dest = Console.ReadLine();

            string sourceFolderName = @"C:\Users\kilyion\source\repos\" + source + "\\" + dossier + "";
            string destFolderName = @"C:\Users\kilyion\source\repos\" + dest + "\\" + dossier + "";
            Directory.Move(sourceFolderName, destFolderName);
            WriteLine($"\n-> Le dossier a bien été déplacé dans {destFolderName}.");
            WriteLine("\n\nAppuyez sur n'importe quel bouton pour revenir au menu...");
            ReadKey(true);
            ViewEN.RunMainMenuEN();
        }

         public class Json
    {
         public String name {get; set; }
        public String FileSource { get; set; }
        public String FileTarget { get; set; }
        public String destPath { get; set; }
        public float FileSize { get; set; }
        public long FileTransferTime { get; set; }
        public String time { get; set; }


    }

        public string SetJson(string path , string despath, float size , long time)
        {
                var json = new Json {
                name = "Move",
                FileSource = path,
                FileTarget = despath,
                destPath = "",
                FileSize = size,
                FileTransferTime = time,
                time = DateTime.Now.ToString("dd/M/y HH:mm:ss")
            };
            string jsonString = JsonSerializer.Serialize(json);
            return jsonString;
        }
         public void FileLog (string json)
        { 
         string path = @"C:\Users\kilyion\source\repos\Log\test.txt" ;
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
                
                try
                {

                    string content;
                    using (StreamReader reader = new StreamReader(path))
                    {
                        content = reader.ReadToEnd();
                       
                        reader.Close();
                    }; 
                    using (StreamWriter sw = new StreamWriter(path))
                        {
                            sw.WriteLine(content +" , "+ json);
                        }

                    
                    // Open the stream and read it back.
                
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
        }

    }
}