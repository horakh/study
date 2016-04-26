using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library
{
    public enum BookType
    {
        SiFi, Fantasy
    }

    class Program
    {
        static void Main(string[] args)
        {
            var color =
            Console.ForegroundColor = ConsoleColor.White;            
            Console.WriteLine("Loading Library Information...");


            // try catch finaly 
            Stream stream;
            StreamReader reader = null;
            try
            {
                throw new FileNotFoundException("Dupa.txt");
                stream = new FileStream("Content/library12.txt", FileMode.Open);
                reader = new StreamReader(stream);
                var text = reader.ReadToEnd();
                Console.WriteLine(text);
            }
            catch (DivideByZeroException ex0)
            {
                Console.WriteLine("Divided by 0 Catched");
                
            }
            catch (FileNotFoundException exfnf)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Could not load configuration file {exfnf.Message}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (reader!=null) reader.Dispose();
            }

            using (StreamReader r = new StreamReader("Content/library.txt"))
            {
                while (!r.EndOfStream)
                {

                    Console.WriteLine(r.ReadLine());
                }
            }

                Console.WriteLine("Loaded");
            Console.ReadKey();
        }
    }
}
