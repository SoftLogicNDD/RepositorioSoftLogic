using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucas
{
    class Program
    {
        public static int TotalDeQuestoes;
        public static int QuestoesObjetivas = 5;
        public static int QuestoesDescritivas = 5;

        public static string[] CadastroDeEnunciadoDaProva()
        {            
            Console.WriteLine(" ========== CADASTRO ==========\n");
            Console.Write("Informe a quantidade de questões descritivas: ");
            QuestoesDescritivas = int.Parse(Console.ReadLine());
            Console.Write("Informe a quantidade de questões objetivas: ");
            QuestoesObjetivas = int.Parse(Console.ReadLine());            

            TotalDeQuestoes = QuestoesDescritivas + QuestoesObjetivas;
            string[] enunciadosDescritivas = new string[QuestoesDescritivas];
            string[] enunciadosObjetivas = new string[QuestoesObjetivas];
            string[] todasQuestoes = new string[TotalDeQuestoes];

            if (QuestoesDescritivas > 0)
            {
                Console.Clear();
                Console.WriteLine("\n ===== Cadastro De Questões Descritivas =====");
                for (int i = 0; i < QuestoesDescritivas; i++)
                {
                    Console.WriteLine("\nDigite o enunciado das questão descritiva {0}: ", i);
                    enunciadosDescritivas[i] = Console.ReadLine();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Não há questões descritivas para cadastro!");
            }

            if (QuestoesObjetivas > 0)
            {
                Console.Clear();
                Console.WriteLine("\n===== Cadastro de Questões Objetivas =====");
                for (int i = 0; i < QuestoesObjetivas; i++)
                {
                    Console.WriteLine("\nDigite o enunciado das questão objetiva {0}: ", i);
                    enunciadosObjetivas[i] = Console.ReadLine();
                }
                CadastraAlternativasDaprova();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Mão há questões objetivas para cadastro!");
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
                Console.WriteLine("ATENÇÃO: Quantidade de Questões Inválida!");
            }
            for (int i = 0; i < TotalDeQuestoes; i++)
            {
                Console.WriteLine(todasQuestoes[i]);
            }
            return todasQuestoes;
        }

        public static string[] CadastraAlternativasDaprova()
        {
            Console.Clear();
            string[] alternativas = new string[QuestoesObjetivas];
            Console.WriteLine("===== Cadastro de Alternativas =====");
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
                    Console.WriteLine("Digite a descrição da alternativa {0}, da questão {1}: ", letras[j], i);
                    alternativas[i] = Console.ReadLine();
                }
            }
            return alternativas;
        }

        public static string[] GerarGabarito(int totalQuestoes)
        {
            Console.WriteLine("===== Gabarito =====");
            string[] alternativaCerta = new string[QuestoesObjetivas];
            string[] RespostaCertaDescritiva = new string[QuestoesDescritivas];
            string[] todasResposta = new string[TotalDeQuestoes];
            for (int i = 0; i < QuestoesObjetivas; i++)
            {
                Console.WriteLine("Qual é a alternativa certa da questão {0}: ", i);
                alternativaCerta[i] = Console.ReadLine();
            }
            for (int i = 0; i < QuestoesDescritivas; i++)
            {
                Console.WriteLine("Digite a resposta descritiva certa da questão {0}: ", i);
                RespostaCertaDescritiva[i] = Console.ReadLine();
            }
            for (int i = 0; i < QuestoesObjetivas; i++)
            {
                todasResposta[i] = alternativaCerta[i];
            }
            int count = 0;
            for (int i = QuestoesObjetivas; i < totalQuestoes; i++)
            {
                todasResposta[i] = RespostaCertaDescritiva[count];
                count++;
            }
            for (int i = 0; i < TotalDeQuestoes; i++)
            {
                Console.WriteLine(" ========== GABARITO =========\n");
                Console.WriteLine(todasResposta[i]);
            }
            return todasResposta;
        }

        public static void GeraGabaritosDeProvasEstaticas()
        {
            //cada prova estatica tem 10 questões randomicas(o enunciado coloquei enunciado+numero da questao+prova+numero da prova)(e considerando que a materia é matematica)
            // nesse mesmo metodo vai ser gerado os gabaritos das 4 provas estaticas(gerado nesse mesmo metodo por motivos de implementação mais simples... 
            //partindo que o padrao das questoes tem 4 opcoes (A,B,C,D e E)
            string[] respostasProvaObjetiva = new string[10];
            string[] respostasProvaObjetiva2 = new string[10];
            string[] respostasProvaDescritiva = new string[10];
            string[] respostasProvaMesclada = new string[10];
            string[] enunciadoProvaObjetiva = new string[10];
            string[] enunciadoProvaObjetiva2 = new string[10];
            string[] enunciadoProvaDescritiva = new string[10];
            string[] enunciadoProvaMesclada = new string[10];
            char[] alternativas = new char[5];
            char[] alternativasRandomicas = "ABCDE".ToCharArray();
            string[] enunciadosProvaMescladaDescritivas = { "teorema de pitagoras", "teorema de tio chiquinho", "teorema do thiago", "teorema do pa e bola", "teorema do zé", "teorema do tio patinhas", "teorema do tio sam", "teorema do tio pinga" };
            int t = 0;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                t = rnd.Next(alternativasRandomicas.Length);
                alternativas[i] = alternativasRandomicas[t];
            }

            //gabarito das 4 provas uma seguinte das outras;
            for (int j = 0; j < 10; j++)
            {
                enunciadoProvaObjetiva[j] = "Enunciado da questao " + j + " da prova objetiva 1";
                respostasProvaObjetiva[j] = "Resposta: " + "- " + j;
                enunciadoProvaObjetiva2[j] = "Enunciado da questao " + j + " da prova objetiva 2";
                respostasProvaObjetiva2[j] = "Resposta: " + "- " + j;
            }
            int l = 0;
            for (int i = 0; i < 10; i++)
            {
                enunciadoProvaDescritiva[i] = "Enunciado da questao " + i + " da prova descritiva";
                l = rnd.Next(enunciadosProvaMescladaDescritivas.Length);
                respostasProvaDescritiva[i] = enunciadosProvaMescladaDescritivas[l];
            }
            int count1 = 0;
            Console.WriteLine("===== Prova 1 (Prova Objetiva 1) =====\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(enunciadoProvaObjetiva[i]);
                Console.WriteLine("Alternativa " + alternativas[count1] + " " + respostasProvaObjetiva[i]);
                count1++;
                if (count1 == 3)
                {
                    count1 = 0;
                }
            }
            Console.WriteLine("===== Prova 2 (Prova Objetiva 2) =====\n");
            int count2 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(enunciadoProvaObjetiva2[i]);
                Console.WriteLine("Alternativa " + alternativas[count2] + " " + respostasProvaObjetiva2[i]);
                count2++;
                if (count2 == 3)
                {
                    count2 = 0;
                }
            }

            int count3 = 0;
            Console.WriteLine("Prova 3 (Prova Descritiva)\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(enunciadoProvaDescritiva[i]);
                Console.WriteLine("Alternativa " + alternativas[count3] + " " + respostasProvaDescritiva[i]);
                count3++;
                if (count3 == 3)
                {
                    count3 = 0;
                }
            }

            int k = 0;

            for (int i = 0; i < 5; i++)
            {
                enunciadoProvaMesclada[i] = "Enunciado da questao " + i + " da prova mesclada";
                k = rnd.Next(enunciadosProvaMescladaDescritivas.Length);
                respostasProvaMesclada[i] = "Resposta " + enunciadosProvaMescladaDescritivas[k];
            }
            for (int i = 5; i < 10; i++)
            {
                enunciadoProvaMesclada[i] = "Enunciado da questao " + i + " da prova mesclada";
                respostasProvaMesclada[i] = "Resposta " + "- " + i;
            }

            Console.WriteLine("===== Prova 4 (Prova Mesclada) =====\n");
            int count4 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(enunciadoProvaMesclada[i]);
                Console.WriteLine("Alternativa " + alternativas[count4] + " " + respostasProvaMesclada[i]);
                count4++;
                if (count4 == 3)
                {
                    count4 = 0;
                }
            }
        }

        static void Main(string[] args)
        {
            CadastroDeEnunciadoDaProva();
            GerarGabarito(TotalDeQuestoes);
            Console.ReadKey();
        }
    }
}
