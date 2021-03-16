using System;
using System.IO;

namespace AgendaTelefonica.Controllers
{
    /*
     * Gravação de log em arquivo
     */
    public class LogFile
    {
        public void AddLine(string line)
        {
            try
            {
                string path = @"log.txt";

                //Se o arquivo não existir, cria e depois insere a linha
                if (!File.Exists(path))
                {
                    using (StreamWriter file = File.CreateText(path))
                    {
                        file.WriteLine(line);
                    }
                }
                //Se o arquivo já existir, adiciona a linha
                using (StreamWriter file = File.AppendText(path))
                {
                    file.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
