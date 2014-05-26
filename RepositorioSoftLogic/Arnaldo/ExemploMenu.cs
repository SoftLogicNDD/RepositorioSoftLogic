using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arnaldo
{
    class ExemploMenu
    {
        static string user = "Thiago";
        static string senha = "thiago123";

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
                    Console.WriteLine("ATENÇÃO: Nome de usuário e senha não conferem! Verifique-os");
                    tentativasErradas++;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sucesso: Você está logado!");
                }

                if (tentativasErradas == 3)
                {
                    Console.Clear();
                    Console.WriteLine("ATENÇÃO: Usuário Bloqueado! \nDados informados incorretamente por mais de 3 vezes!");
                    break;
                }
            } while (!status);
            Console.ReadKey();
        }

        public static bool VerificarCredenciais()
        {
            Console.Clear();
            Console.WriteLine(" ===== LOGIN =====");
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
