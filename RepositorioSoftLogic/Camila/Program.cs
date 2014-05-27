using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camila
{
    class Program
    {
        static string user = "Thiago";
        static string senha = "thiago123";
        static int Opcao;
        static void Main(string[] args)
        {
            RealizarLogin();
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
                Console.WriteLine("=========================== MENU ===========================");
                Console.WriteLine("\n\n\n\n\n\n\n");
                Console.WriteLine("1 - Movimento (Cadastrar Prova / Editar / Remover");
                Console.WriteLine("2 - Consulta (Relatório)");
                Console.WriteLine("3 - Ajuda (Documentação - como funciona)");
                Console.WriteLine("4 - Sobre (Nomes da equipe e nome da empresa)");
                Console.WriteLine("5 - Encerrar o programa.");
                Console.WriteLine("\n\n\n\n\n\n\n\n");
                Console.Write("Informe a opção desejada: ");
                Opcao = int.Parse(Console.ReadLine());
            }
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
            if (nameUser.ToUpper() == user.ToUpper() && senha == senhaUser)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}