using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arnaldo
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine(" ===== AJUDA =====");
            MostrarOpcoes();
            Console.Write("\nInforme a opção desejada: ");
            int opcaoMenuAjuda = int.Parse(Console.ReadLine());
            //switch (opcaoMenuAjuda)
            //{
            //    case 1:
            //        AjudaCadastro();
            //    case 2:
            //        AjudaConsulta();
            //    case 3:
            //        MenuInicial();
            //    default:
            //        Console.WriteLine("ATENÇÃO! Opção Inválida");
            //}
            Console.ReadKey();
        }

        static void MostrarOpcoes()
        {
            Console.WriteLine("1 - Cadastro \n2 - Consultas \n3 - Retornar ao Menu Inicial");
        }
    }
}
