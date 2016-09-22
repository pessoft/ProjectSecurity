using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GenerateAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                File.WriteAllText(@"D:\Dev\ProjectSecurity\Security\Security\Resource\Alphabet.ini", Alphabet.GetAlphabet());
            }
            catch
            {
                Console.WriteLine("error");
            }

            Console.WriteLine("Success");

            Console.ReadKey();
        }
    }
}
