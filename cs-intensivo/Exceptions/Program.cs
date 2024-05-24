using System;
using System.IO;
using System.Net.Mime;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
            string content1 = File.ReadAllText(@"C:\Repos\cs-intensivo\Datos.txt");                
            Console.WriteLine(content1);

            string content2 = File.ReadAllText(@"C:\Repos\cs-intensivo\Datos2.txt");
            Console.WriteLine(content2);

            throw new Exception("Mi propia excepción");
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("El archivo no existe");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error");
                Console.WriteLine(ex.Message);
            }
            finally
            {                
                Console.WriteLine("El bloque finally siempre se ejecuta");
            }

            Console.WriteLine("El código continua ejecutandose...");
        }
    }
}
