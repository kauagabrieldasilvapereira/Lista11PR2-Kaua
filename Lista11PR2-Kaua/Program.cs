using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista11PR2_Kaua
{
    internal class Program
    {
        public static void Exercicio1()
        {
            int numero1, parada = 0;
            int[] vetor1;
            vetor1 = new int[1000];
            Random rand = new Random();

            for (int i = 0; i < 1000; i++)
            {
                vetor1[i] = rand.Next(1, 10);

                Console.WriteLine("Tente advinhar um numero entre 1 e 1000");
                numero1 = int.Parse(Console.ReadLine());

                for (int z = 0; z < numero1; z++)
                    if (vetor1[i] == numero1)
                    {
                        Console.WriteLine("Voce advinhou o numero parabens");
                        parada = 1;
                        break;
                    }
                if (parada == 1)
                {
                    break;
                }
            }
        }
        public static void Exercicio2()
        {
            int numero2, quantidade = 0;
            int[] vetor2;
            vetor2 = new int[20000];
            Random rand = new Random();

            for (int i = 0; i < 20000; i++)
            {
                vetor2[i] = rand.Next(1, 10);
            }
            Console.WriteLine("Digite um numero aleatorio até 10");
            numero2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < 20000; i++)
            {
                if (vetor2[i] == numero2)
                {
                    quantidade += 1;
                }
            }
            Console.WriteLine("Essa é a quantidade de numeros no vetor {0}", quantidade);
        }
        public static void Exercicio3()
        {
            int[] vetor3, vetor4, vetor5;

            vetor3 = new int[10];

            vetor4 = new int[10];

            vetor5 = new int[10];

            Random rand = new Random();

            for (int i = 0; i < 10; i++)

            {
                vetor3[i] = rand.Next(1, 100);

            }

            for (int i = 0; i < 10; i++)
            {

                if (vetor3[i] % 2 == 0)
                {

                    vetor4[i] = vetor3[i] / 2;
                    Console.WriteLine("O numero par é {0} ", vetor4[i]);
                }

                else

                {
                    vetor5[i] = vetor3[i] * 3;
                    Console.WriteLine("O numero impar é {0}", vetor5[i]);
                }
            }
        }
        public static void Exercicio4()
        {
            int[] vetor6, numero3;
            vetor6 = new int[5000];
            Random rand = new Random();

            for (int i = 0; i < 5000; i++)
            {
                vetor6[i] = rand.Next(1, 10);
            }

            for (int i = 1; i < 5000; i++)
            {
                for (int j = 2; j < vetor6[i]; j++)
                {
                    if (vetor6[i] % j == 1)
                    {
                        Console.WriteLine("O nuemro {0} é primo", vetor6[i]);
                    }
                }
            }
        }

        static void Main(string[] args)

        {

            int opcao;
            do
            {
                Console.WriteLine("=================MENU=================");
                Console.WriteLine("Para sair - digite 0");
                Console.WriteLine("Para executar o exercicio 1 - digite 1");
                Console.WriteLine("Para executar o exercicio 2 - digite 2");
                Console.WriteLine("Para executar o exercicio 3 - digite 3");
                Console.WriteLine("Para executar o exercicio 4 - digite 4");
                Console.WriteLine("======================================");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado por utilizar o programa");

                        break;
                    case 1:
                        Exercicio1();

                        break;
                    case 2:
                        Exercicio2();

                        break;
                    case 3:
                        Exercicio3();

                        break;
                    case 4:
                        Exercicio4();

                        break;
                }
            } while (opcao != 0);
        }
    }
}
