using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo para o Quiz sobre geografia!!");
            Console.WriteLine("clique em alguma tecla para iniciar!");
            Console.ReadLine();
                       
            Console.WriteLine("Quantos oceanos existem no planeta?");
            List<string> list = new List<string>();
            list.Add(" a) 4 oceanos \r\n b) 6 oceanos \r\n c) 3 oceanos \r\n d) 8 oceanos");
            respostas Respostar = new respostas();
            Respostar.resposta(list);
            string resposta1 = (Console.ReadLine());

           Console.WriteLine("Qual e a capital do brasil?\t ");
            List<string> list2 = new List<string>();
            list2.Add(" a) natal \r\n b) São paulo \r\n c) brasilia \r\n d) amazonia ");
            
            respostas Resposta2 = new respostas();
            Resposta2.resposta2(list2);
            string resposta2 = (Console.ReadLine());


            if (resposta1 == "a" && resposta2 == "c")
            {
                Console.WriteLine("parabens você acertou todoas as perguntas");

            }
            else if (resposta1 == "a" && resposta2 != "c")
            {
                Console.WriteLine("voce acertou a primeira é errou a segunda");
            }
            else if (resposta1 != "a" && resposta2 == "c")
            {
                Console.WriteLine("voce errou a primeira é acertou a segunda" +
                    "");
            }
            else
            {
                Console.WriteLine("você errou todas as perguntas!!");
            }

            Console.ReadLine();
    
        }
    }
}
