using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores_relacionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //operadores logicos

            double peso; byte edad;

            Console.WriteLine("digite su peso");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite tu edad");
            edad = Convert.ToByte(Console.ReadLine());

            Console.Clear();

            if (peso > 100 && edad >= 15)
            {
                Console.WriteLine("tu peso es normal");

            }

            Console.ReadKey();






        }
    }
}
