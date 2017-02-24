using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEntrega
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader reader = new StreamReader("nomes_telefones.txt");
            Console.WriteLine(reader);

            String linha = reader.ReadLine();
            
            while (linha != null)
            {
                linha = linha.Replace("-", "").Replace("(", "").Replace(")", "");
                Console.WriteLine(linha);
                linha = reader.ReadLine();
            }
            
            Console.ReadKey();
        }
    }
}
