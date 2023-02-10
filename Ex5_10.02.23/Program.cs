using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_10._02._23
{
    public class Program
    {
        static void Main(string[] args)
        {
            double nmr1 = 0;
            double nmr2 = 0;

            Console.WriteLine("Digite um número: ");
            nmr1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            nmr2 = Convert.ToDouble(Console.ReadLine());

            if (nmr1 > nmr2)
            {
                Console.WriteLine("O primeiro número é maior");
            }
            else if (nmr2 > nmr1)
            {
                Console.WriteLine("O segundo número é maior");
            }
            else 
            {
                Console.WriteLine("Os números são iguais");
            }
            
        }
    }
}
