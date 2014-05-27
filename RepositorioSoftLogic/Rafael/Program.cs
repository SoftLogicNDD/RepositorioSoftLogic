using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael
{
    class Program
    {
        public static int totalDeQuestoes;
        public static int questoesObjetivas=5;
        public static int questoesDescritivas=5;

        public static string[] CadastroDeEnunciadoDaProva()
        {
           
             totalDeQuestoes = questoesDescritivas + questoesObjetivas;
            string[] enunciadosDescritivas = new string[questoesDescritivas];
            string[] enunciadosObjetivas = new string[questoesObjetivas];
           string[] todasQuestoes = new string[totalDeQuestoes];
            

            if (questoesDescritivas > 0)
            {
                Console.WriteLine("cadastro de questoes descritivas");
                for (int i = 0; i < questoesDescritivas; i++)
                {
                    Console.WriteLine("digite o enunciado das questoes descritivas:");
                    enunciadosDescritivas[i] = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("não há questões descritivas para cadastro...");
            }
            if (questoesObjetivas > 0)
            {
                Console.WriteLine("cadastro de questoes objetivas");
                for (int i = 0; i < questoesObjetivas; i++)
                {
                    Console.WriteLine("digite o enunciado das questoes objetivas:");
                    enunciadosObjetivas[i] = Console.ReadLine();
                }
                CadastraAlternativasDaprova();
            }
            else
            {
                Console.WriteLine("não há questões objetivas para cadastro...");
            }
            if (questoesDescritivas > 0 && questoesObjetivas > 0)
            {
                for (int i = 0; i < questoesObjetivas; i++)
                {
                    todasQuestoes[i] = enunciadosObjetivas[i];
                }
                int countDesc = 0;
                for (int i = questoesObjetivas; i < totalDeQuestoes; i++)
                {
                    todasQuestoes[i] = enunciadosDescritivas[countDesc];
                    countDesc++;
                }
            }
            else if (questoesDescritivas > 0 && questoesObjetivas == 0)
            {
                for (int i = 0; i <= totalDeQuestoes; i++)
                {
                    todasQuestoes[i] = enunciadosDescritivas[i];
                }
            }
            else if (questoesObjetivas > 0 && questoesDescritivas == 0)
            {

                for (int i = 0; i < totalDeQuestoes; i++)
                {
                    todasQuestoes[i] = enunciadosObjetivas[i];
                }
            }
            else
            {
                Console.WriteLine("quantidade de questoes invalida");
            }
            for (int i = 0; i < totalDeQuestoes; i++)
            {
                Console.WriteLine(todasQuestoes[i]);
            }



            return todasQuestoes;
           
        }

        public static string[] CadastraAlternativasDaprova()
        {
            string[] alternativas = new string[questoesObjetivas];
            Console.WriteLine("cadastro de alternativas:");
            char[] letras = new char[5];
            letras[0] = 'A';
            letras[1] = 'B';
            letras[2] = 'C';
            letras[3] = 'D';
            letras[4] = 'E';
            for (int i = 0; i < questoesObjetivas; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("digite a descrição da alternativa {0}, da questao :{1}", letras[j], i);
                    alternativas[i] = Console.ReadLine();

                }
            }
            return alternativas;
        }
        public static void Consultar()
        {
            CadastroDeEnunciadoDaProva();

            int opc;
            Console.WriteLine("/////////// Consultar Gabaritos ///////////");
            Console.WriteLine("1 - Ver prova descritiva ");
            Console.WriteLine("2 - Ver prova objetiva ");
            Console.WriteLine("3 - Ver prova mesclada ");
            Console.WriteLine("4 - Ver questoes");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:                    
                 for (int i = 0; i < totalDeQuestoes; i++)
                    {
                        Console.WriteLine(todasQuestoes[i]);
                    }
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
