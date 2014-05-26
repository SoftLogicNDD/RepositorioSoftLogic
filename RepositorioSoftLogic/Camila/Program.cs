using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camila
{
    class Program
    {
        public static string Login, Senha, Menu;
        public static int Opcao;

        static void Main(string[] args)
        {
            Console.WriteLine("=============== SEJA BEM VINDO! ===============");
            Console.WriteLine("\n\n");
            //Cadastro(Login, Senha);
            realizarLogin(Login, Senha);
            Console.Clear();
            MenuIniciar(Menu);
            Console.Write("Informe a opção desejada: ");
            Opcao = int.Parse(Console.ReadLine());
            

            Console.ReadLine();
        }
        

        private static string Cadastro (string Login, string Senha)
        {
            
            Console.Write("Login: ");
            Login = Console.ReadLine();
            Console.Write("Senha: ");
            Senha = Console.ReadLine();
            Console.Clear();

            if (Senha == "Thiago" + 123)
            {
                Console.WriteLine("Senha válida! Aguarde o carregamento!");
            }

            else
            {
                Console.WriteLine("Senha inválida! Tente novamente!");

                for (int i = 0; i < 2; i++)
                {
                    Console.Write("Login: ");
                    Login = Console.ReadLine();
                    Console.Write("Senha: ");
                    Senha = Console.ReadLine();
                    Console.Clear();

                    if (Senha == "Thiago" + 123)
                    {
                        Console.WriteLine("Senha válida! Aguarde o carregamento!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Tente novamente!");
                    }

                }
            }

            return Login;

        }

        public static void realizarLogin(string Login, string Senha)
        {
            mostraLogin();
            int countErradas = 0;
            if (Senha == "Thiago" + 123)
            {
                Console.WriteLine("Senha válida! Aguarde o carregamento!");
            }
            else
            {
                countErradas++;
                if (countErradas < 3)
                {
                    mostraLogin();
                }
                else
                {
                    Console.WriteLine("Usuário bloqueado!");
                    
                }
            }

        }

        public static void mostraLogin()
        {
            Console.Write("Login: ");
            Login = Console.ReadLine();
            Console.Write("Senha: ");
            Senha = Console.ReadLine();
            Console.Clear();
        }

        private static string MenuIniciar(string Menu)
        {
            Console.WriteLine("========================= MENU ===========================");
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.WriteLine("1 - Movimento (Cadastrar Prova / Editar / Remover");
            Console.WriteLine("2 - Consulta (Relatório)");
            Console.WriteLine("3 - Ajuda (Documentação - como funciona)");
            Console.WriteLine("4 - Sobre (Nomes da equipe e nome da empresa)");
            Console.WriteLine("5 - Encerrar o programa.");
            Console.WriteLine("\n\n\n\n\n\n\n\n");

            return Menu;
        }
    }

    
}
