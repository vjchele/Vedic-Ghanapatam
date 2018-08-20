using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ghanapatam
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string input = @"Fresh snow Sun's first rays Monsoon rain Kalpana's assurance on my weak confidence";
            Ganapatham(input.Split(' '));           

            Console.Read();

        }

        static void Ganapatham(string[] input)
        {
           

            using (var sw = new StreamWriter(@"C: \Users\vcheleenahalli\source\repos\Ghanapatam\Ghanapatam\Ghanapatam_Linq.txt"))
            {
                while (input.Length > 2)
                {
                    sw.WriteLine(string.Join(" ", input.Take(2).ToArray()));
                    sw.WriteLine(string.Join(" ", input.Take(2).ToArray().Reverse().ToArray()));
                    sw.WriteLine(string.Join(" ", input.Take(3).ToArray()));
                    sw.WriteLine(string.Join(" ", input.Take(3).ToArray().Reverse()));
                    sw.WriteLine(string.Join(" ", input.Take(3).ToArray()));
                    sw.WriteLine(" ");
                    input = input.Skip(1).ToArray();


                }
            }
                
            
        }

    }
}
