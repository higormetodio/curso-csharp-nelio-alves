using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Digite o número de casos: ");
            int _n = int.Parse(Console.ReadLine());

            double[] medias = new double[_n];


            for (int i = 0; i < _n; i++)
            {
                string[] _valores;
                double[] notas = new double[3];

                Console.Write("Digite 3 valores reais: ");
                _valores = Console.ReadLine().Split(' ');
                notas[0] = double.Parse(_valores[0]);
                notas[1] = double.Parse(_valores[1]);
                notas[2] = double.Parse(_valores[2]);

                medias[i] = (notas[1] * 2 + notas[2] * 3 + notas[3] * 5) / 3;
            }

            Console.WriteLine("Finalizado.");
        }
    }
}
