using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetorzinn
{  
    internal class Program
    {
        public static void Exercicio1()
        {
            Console.WriteLine("Exercicio1 1");
            int[] vetz2;

            Console.WriteLine("Entre com o tamanho:");
            int t = int.Parse(Console.ReadLine());

            vetz2 = new int[t];
            Random rand = new Random();

            float soma = 0;
            for (int i = 0; i < t; i++)
            {
                vetz2[i] = rand.Next(10, 50);
                soma = soma + vetz2[i];
            }
            Console.WriteLine("A media é :" + soma / (float)t);

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição[{0}] = {1}", i, vetz2[i]);

            }

        }
        public static void Exercicio2()
        {

        }


        static void Main(string[] args)
        {
            int exercicio;
            do
            {
                Console.WriteLine("======Menu======");
                Console.WriteLine("exercicio 1 - Digite1");
                Console.WriteLine("exercicio 2 - Digite2");
               
                Console.WriteLine("Digite 0 - caso queira sair:");

                exercicio = int.Parse(Console.ReadLine());

                switch (exercicio)
                {
                    case 0:
                        Console.WriteLine("Obrigada por utilizar este programa!!!");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    default:
                        Console.WriteLine("Opção invalida:");
                        break;
                }
            } while (exercicio != 0);



        }
    }
}
