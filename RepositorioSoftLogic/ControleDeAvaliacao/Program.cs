using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAvaliacao
{
    class Program
    {
        static string User = "Thiago";
        static string Senha = "thiago123";
        static int Opcao;
        static void Main(string[] args)
        {
            bool status = false;
            int tentativasErradas = 0;
            do
            {
                status = VerificarCredenciais();
                if (!status)
                {
                    Console.Clear();
                    Console.WriteLine("=========================== ATENÇÃO! ===========================");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Nome de usuário e senha não conferem! Verifique-os.\n \nAperte ENTER para continuar");
                    tentativasErradas++;
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.Write("Sucesso: Você está logado!\n \nAperte ENTER para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (tentativasErradas == 3)
                {
                    Console.Clear();
                    Console.WriteLine("=========================== ATENÇÃO! ===========================");
                    Console.WriteLine("\n\n\n\n\n\n\n\n ");
                    Console.WriteLine("Usuário Bloqueado! \nDados informados incorretamente por 3 vezes seguidas!\n");
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n ");
                    break;
                }
            } while (!status);

            if (!status)
            {
                Console.WriteLine("Tente novamente mais tarde!");
            }
            else
            {
                do
                {
                    Console.Clear();
                    Opcao = MostrarMenu();
                    switch (Opcao)
                    {
                        case 3:
                            MostrarAjuda();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("ATENÇÃO: Opção Inválida! \nPressione ENTER para continuar.");
                            Console.ReadKey();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("Até Logo!");
                            break;
                    }
                } while (Opcao != 5);               
            }
            Console.ReadKey();
        }

        public static void RealizarLogin()
        {
            bool status = false;
            int tentativasErradas = 0;
            do
            {
                status = VerificarCredenciais();
                if (!status)
                {
                    Console.Clear();
                    Console.WriteLine("=========================== ATENÇÃO! ===========================");
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Nome de usuário e senha não conferem! Verifique-os.\n \nAperte ENTER para continuar");
                    tentativasErradas++;
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.Write("Sucesso: Você está logado!\n \nAperte ENTER para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (tentativasErradas == 3)
                {
                    Console.Clear();
                    Console.WriteLine("=========================== ATENÇÃO! ===========================");
                    Console.WriteLine("\n\n\n\n\n\n\n\n ");
                    Console.WriteLine("Usuário Bloqueado! \nDados informados incorretamente por 3 vezes seguidas!\n");
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n ");
                    break;
                }
            } while (!status);

            if (!status)
            {
                Console.WriteLine("Tente novamente mais tarde!");
            }
            else
            {
                Opcao = MostrarMenu();
            }
        }

        public static int MostrarMenu()
        {
            Console.WriteLine("=========================== MENU ===========================");
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.WriteLine("1 - Movimento (Cadastrar Prova / Editar / Remover");
            Console.WriteLine("2 - Consulta (Relatório)");
            Console.WriteLine("3 - Ajuda (Documentação - como funciona)");
            Console.WriteLine("4 - Sobre (Nomes da equipe e nome da empresa)");
            Console.WriteLine("5 - Encerrar o programa.");
            Console.WriteLine("\n\n\n\n\n\n\n\n");
            Console.Write("Informe a opção desejada: ");
            return int.Parse(Console.ReadLine());
        }

        public static bool VerificarCredenciais()
        {
            Console.Clear();
            Console.WriteLine(" =========================== LOGIN ===========================");
            Console.WriteLine("\n\n");
            Console.Write("Informe o nome de usuário: ");
            string nameUser = Console.ReadLine();
            Console.Write("Informe a senha: ");
            string senhaUser = Console.ReadLine();
            if (nameUser.ToUpper() == User.ToUpper() && Senha == senhaUser)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void MostrarOpcoesAjuda()
        {
            Console.WriteLine("1 - Cadastro \n2 - Consultas \n3 - Retornar ao Menu Inicial");
        }

        static void MostrarAjuda()
        {
            int opcaoMenuAjuda = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(" ===== AJUDA =====");
                MostrarOpcoesAjuda();
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
                        string instrucoesCadastro3 = "A próxima etapa consiste em cadastrar a descrição das alternativas que \npertencem as questões objetivas";
                        Console.WriteLine("\n2 - Cadastrar: \n \n2.1 - {0}\n2.2 - {1}\n2.3 - {2}\n", instrucoesCadastro, instrucoesCadastro2, instrucoesCadastro3);

                        string instrucoesGabarito = "O primeiro passo da geração de gabarito é informar qual é a alternativa \ncorreta das questões objetivas";
                        string instrucoesGabarito2 = "Após isso, basta informa quais são as respostas para ser ter base na \ncorreção das questões descritivas. \n3.3 - Com todas essas etapas feitas, o programa irá exibir na tela o gabarito \n(Questão e sua respectiva resposta)";
                        Console.WriteLine("\n3 - Gabarito: \n \n3.1 - {0} \n3.2 - {1}", instrucoesGabarito, instrucoesGabarito2);


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
        }
    }
}
