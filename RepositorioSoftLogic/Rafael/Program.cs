using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafael
{
    class Program
    {
        public static int TotalDeQuestoes;
        public static int QuestoesObjetivas = 5;
        public static int QuestoesDescritivas = 5;

        public static string[] CadastroDeEnunciadoDaProva()
        {

            TotalDeQuestoes = QuestoesDescritivas + QuestoesObjetivas;
            string[] enunciadosDescritivas = new string[QuestoesDescritivas];
            string[] enunciadosObjetivas = new string[QuestoesObjetivas];
            string[] todasQuestoes = new string[TotalDeQuestoes];


            if (QuestoesDescritivas > 0)
            {
                Console.WriteLine("cadastro de questoes descritivas");
                for (int i = 0; i < QuestoesDescritivas; i++)
                {
                    Console.WriteLine("digite o enunciado das questoes descritivas:");
                    enunciadosDescritivas[i] = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("não há questões descritivas para cadastro...");
            }
            if (QuestoesObjetivas > 0)
            {
                Console.WriteLine("cadastro de questoes objetivas");
                for (int i = 0; i < QuestoesObjetivas; i++)
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
            if (QuestoesDescritivas > 0 && QuestoesObjetivas > 0)
            {
                for (int i = 0; i < QuestoesObjetivas; i++)
                {
                    todasQuestoes[i] = enunciadosObjetivas[i];
                }
                int countDesc = 0;
                for (int i = QuestoesObjetivas; i < TotalDeQuestoes; i++)
                {
                    todasQuestoes[i] = enunciadosDescritivas[countDesc];
                    countDesc++;
                }
            }
            else if (QuestoesDescritivas > 0 && QuestoesObjetivas == 0)
            {
                for (int i = 0; i <= TotalDeQuestoes; i++)
                {
                    todasQuestoes[i] = enunciadosDescritivas[i];
                }
            }
            else if (QuestoesObjetivas > 0 && QuestoesDescritivas == 0)
            {

                for (int i = 0; i < TotalDeQuestoes; i++)
                {
                    todasQuestoes[i] = enunciadosObjetivas[i];
                }
            }
            else
            {
                Console.WriteLine("quantidade de questoes invalida");
            }
            for (int i = 0; i < TotalDeQuestoes; i++)
            {
                Console.WriteLine(todasQuestoes[i]);
            }



            return todasQuestoes;

        }

        public static string[] CadastraAlternativasDaprova()
        {
            string[] alternativas = new string[QuestoesObjetivas];
            Console.WriteLine("cadastro de alternativas:");
            char[] letras = new char[5];
            letras[0] = 'A';
            letras[1] = 'B';
            letras[2] = 'C';
            letras[3] = 'D';
            letras[4] = 'E';
            for (int i = 0; i < QuestoesObjetivas; i++)
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
                    for (int i = 0; i < TotalDeQuestoes; i++)
                    {
                        //Console.WriteLine(todasQuestoes[i]);
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
