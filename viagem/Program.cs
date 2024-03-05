using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viagem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("quantos adultos irão?");
            int adul = int.Parse(Console.ReadLine());
            Console.WriteLine("quantas criancas irão?");
            int cri = int.Parse(Console.ReadLine());
            Console.WriteLine("valor da diaria");
            double dia = double.Parse(Console.ReadLine());
            Console.WriteLine("quantos dias irão passar no hotel?");
            int dias = int.Parse(Console.ReadLine());

            double total = (dia * adul + ((cri * dia)/2))*dias;

            Console.WriteLine("valor da diaria" + dia);
            Console.WriteLine("quantos adultos" + adul);
            Console.WriteLine("quantas crianças" + cri);
            Console.WriteLine("quantos dias irao passas:" +dias);
            Console.WriteLine("o valor total da hospedagem:" + total);

            Console.ReadKey();


        }
    }
}
