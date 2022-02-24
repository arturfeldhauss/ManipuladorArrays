using System;
using System.Linq;

namespace ManipuladorArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] numeros = new string[10];
            // imput dos numeros
            Console.WriteLine("Escreva 10 numeros!!");
            Console.WriteLine("----------------------");
            string[] snumeros = numeros;
            double[] dnumeros = new double[10];
            //dnumeros[0] = double.Parse(Console.ReadLine());
            //dnumeros[1] = double.Parse(Console.ReadLine());
            //dnumeros[2] = double.Parse(Console.ReadLine());
            //dnumeros[3] = double.Parse(Console.ReadLine());
            //dnumeros[4] = double.Parse(Console.ReadLine());
            //dnumeros[5] = double.Parse(Console.ReadLine());
            //dnumeros[6] = double.Parse(Console.ReadLine());
            //dnumeros[7] = double.Parse(Console.ReadLine());
            //dnumeros[8] = double.Parse(Console.ReadLine());
            //dnumeros[9] = double.Parse(Console.ReadLine());
            for (int i = 0; i < dnumeros.Length;i++)
            {
                dnumeros[i] = double.Parse(Console.ReadLine());
            }
           //menu de escolhas            
            Console.WriteLine("Escolha o que quer fazer com os numeros!!!");
            Console.WriteLine("1 - Encontrar o Maior Valor da sequência");
            Console.WriteLine("2 - Encontrar o Menor Valor da sequência");
            Console.WriteLine("3 - Encontrar o Valor Médio da sequência");
            Console.WriteLine("4 - Encontrar os 3 maiores valores da sequência");
            Console.WriteLine("5 - Encontrar os valores negativos da sequência");
            Console.WriteLine("6 - Mostrar na Tela os valores da sequência");
            Console.WriteLine("7 - Remover um item da sequência");
            string opcao = Console.ReadLine();
            //Criando as variaveis!!!
            Array.Sort(dnumeros);
            double soma = dnumeros[0] + dnumeros[1] + dnumeros[2] + dnumeros[3] + dnumeros[4] + dnumeros[5] + dnumeros[6] + dnumeros[7] + dnumeros[8] + dnumeros[9];
            double maior = dnumeros.Max();
            double menor = dnumeros.Min();
            double media = soma / 10;
            int numerosint = Convert.ToInt32(dnumeros);
            //Organizando as opçoes
            if (opcao == "1")
            {
                Console.WriteLine("O maior numero é {0}", maior);
            }
            if(opcao == "2")
            {
                Console.WriteLine("O menor numero é {0}", menor);
            }
            if (opcao == "3")
            {
                Console.WriteLine("A media dos numeros é {0}", media);
            }
            if (opcao == "4")
            {
                Console.WriteLine("Os 3 maiores numeros são {0}, {1}, {2}", dnumeros[9], dnumeros[8], dnumeros[7]);
            }
            if (opcao == "5")
            {
                foreach (int i in numerosint)
                {
                    if (i < 0) 
                    {
                        Console.WriteLine("Os numeros negativos são " + i);
                    }
                }          
            }
            if (opcao == "6")
            {
                Console.WriteLine("A sequencia é {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}", dnumeros[0], dnumeros[1], dnumeros[2], dnumeros[3], dnumeros[4], dnumeros[5], dnumeros[6], dnumeros[7], dnumeros[8], dnumeros[9]);
            }
            if(opcao == "7")
            {
                Console.WriteLine("Escolha qual a posicao do numero que quer remover!!!");
                string opcao3 = Console.ReadLine();
                
                


            }

           







            Console.ReadLine();
        }
    }
}
