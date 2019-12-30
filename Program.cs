using System;
using System.IO;
using System.Collections.Generic;

namespace Manip.Arq
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\aff-o\source\repos\Manip.Arq\New";

            try
            {

                //LISTANDO OS DIRETORIOS 
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                //ou
                //(importado IEnumerable automaticamente) var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Folders: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                //LISTANDO OS ARQUIVOS
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Files: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                //CRIANDO UMA PASTA
                Directory.CreateDirectory(path + "\\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR!!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
