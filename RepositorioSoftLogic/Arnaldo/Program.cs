using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arnaldo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoMenuAjuda = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(" ===== AJUDA =====");
                MostrarOpcoes();
                Console.Write("\nInforme a opção desejada: ");
                opcaoMenuAjuda = int.Parse(Console.ReadLine());
                switch (opcaoMenuAjuda)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(" ===== AJUDA - CADASTRO ===== \n");

                        string qObjetivas = "\nQuestões objetivas são as questões que possuem 5 alternativas corretas (A,B,C,D,E) que possuem apenas uma alternativa correta";
                        string qDescritivas = "\nQuestões descritivas: são questões abertas. Ou seja, são perguntas onde você \nterá que ESCREVER as respostas.";                       
                        Console.WriteLine("1 - Tipos de questões: \n{0}\n{1}", qObjetivas, qDescritivas);

                        string instrucoesCadastro = "Para cadastrar uma prova, inicialmente o usuário deve informar a \nquantidade de questões descritivas e de questões objetivas.";
                        string instrucoesCadastro2 = "Em seguida, o usuário irá informar o enunciado das questões descritivas e das questões objetivas";
                        Console.WriteLine("\n2 - Cadastrar: \n2.1 - {0}\n2.2 - {1}", instrucoesCadastro,instrucoesCadastro2);

                        Console.WriteLine("\nPressione a tecla ENTER para continuar: ");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(" ===== AJUDA - CONSULTA ===== \nAperte ENTER para continuar");
                        Console.ReadKey();
                        break;
                    case 3:                        
                        Console.Clear();
                        Console.WriteLine("Aperte ENTER para continuar");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("ATENÇÃO! Opção Inválida \nAperte ENTER para continuar");
                        Console.ReadKey();
                        break;
                }
            } while (opcaoMenuAjuda != 3);
            Console.WriteLine("Até Logo");
            Console.ReadKey();
        }

        static void MostrarOpcoes()
        {
            Console.WriteLine("1 - Cadastro \n2 - Consultas \n3 - Retornar ao Menu Inicial");
        }
    }
}
