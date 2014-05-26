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
            Console.WriteLine(" ===== AJUDA =====\n");
            MostrarOpcoes();
            Console.Write("Informe a opção desejada: ");
            int opcaoMenuAjuda = int.Parse(Console.ReadLine());
            //switch (opcaoMenuAjuda)
            //{
            //}
            Console.ReadKey();
        }

        static void MostrarOpcoes()
        {
            Console.WriteLine("1 - Cadastro \n2 - Consultas \n3 - Retornar ao Menu Inicial");
        }
    }
}
