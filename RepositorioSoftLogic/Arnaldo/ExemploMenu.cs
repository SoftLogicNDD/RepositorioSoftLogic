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
                    Console.WriteLine("ATENÇÃO: Nome de usuário e senha não conferem! Verifique-os\n \nAperte ENTER para continuar");
                    tentativasErradas++;
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sucesso: Você está logado!\n \nAperte ENTER para continuar");
                    Console.ReadKey();
                }

                if (tentativasErradas == 3)
                {
                    Console.Clear();
                    Console.WriteLine("ATENÇÃO: Usuário Bloqueado! \nDados informados incorretamente por 3 vezes seguidas!\nAperte ENTER para continuar");                    
                    break;
                }
            } while (!status);

            if(!status){
                Console.WriteLine("Até Logo");
            }
            else
            {
                //Continua o Menu
            }
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
