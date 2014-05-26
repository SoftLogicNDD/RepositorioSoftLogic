using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucas
{
    class Program
    {
        public static int totalDeQuestoes=10;
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



        public static char[] GerarGabarito(int totalQuestoes)
        {
            Console.WriteLine("gabarito");
            
            string [] alternativaCerta = new string[questoesObjetivas];
            string[] RespostaCertaDescritiva =new string[questoesDescritivas];
            string[]todasResposta=new string[totalDeQuestoes];
            for (int i = 0; i < questoesObjetivas; i++)
        {
                Console.WriteLine("qual é a alternativa certa");
                alternativaCerta[i] = Console.ReadLine();


            }
            for (int i = 0; i < questoesDescritivas; i++)
            {
                Console.WriteLine("digite a resposta descritiva certa:");
                RespostaCertaDescritiva[i] = Console.ReadLine();
            }
            for (int i = 0; i < questoesObjetivas; i++)
            {
                todasResposta[i] = alternativaCerta[i];
            }
            for (int i = questoesObjetivas; i < questoesDescritivas; i++)
            {
                todasResposta[i] = RespostaCertaDescritiva[i];
            }
            for (int i = 0; i < totalDeQuestoes; i++)
            {
                Console.WriteLine(todasResposta[i]);
            }
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
                    enunciadoProvaObjetiva[j] = "enunciado da questao " + j + " da prova objetiva 1"; 
                respostasProvaObjetiva[j] = "resposta: " + "- " + j;
                    enunciadoProvaObjetiva2[j] = "enunciado da questao " + j + " da prova objetiva 2";
                    respostasProvaObjetiva2[j] = "resposta: " + "- " + j;
                    
                    
                }
             int l = 0;
            for (int i = 0; i < 10; i++)
            {
                enunciadoProvaDescritiva[i] = "enunciado da questao " + i + " da prova descritiva";
                l = rnd.Next(enunciadosProvaMescladaDescritivas.Length);
                respostasProvaDescritiva[i] = enunciadosProvaMescladaDescritivas[l];
            }
            int count1 = 0;
            Console.WriteLine("prova 1 (prova objetiva 1)\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(enunciadoProvaObjetiva[i]);
                Console.WriteLine("alternativa " + alternativas[count1] + " " + respostasProvaObjetiva[i]);
                count1++;
                if (count1 == 3)
                {
                    count1 = 0;
                }
            }
            Console.WriteLine("prova 2 (prova objetiva 2)\n");
            int count2 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(enunciadoProvaObjetiva2[i]);
                Console.WriteLine("alternativa " + alternativas[count2] + " " + respostasProvaObjetiva2[i]);
                count2++;
                if (count2 == 3)
                {
                    count2 = 0;
                }
            }
          
            int count3 = 0;
            Console.WriteLine("prova 3 (prova descritiva)\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(enunciadoProvaDescritiva[i]);
                Console.WriteLine("alternativa " + alternativas[count3] + " " + respostasProvaDescritiva[i]);
                count3++;
                if (count3 == 3)
                {
                    count3 = 0;
                }
            }         
            
            
                      
            int k = 0;
           
            for (int i = 0; i < 5; i++)
            {
                enunciadoProvaMesclada[i] = "enunciado da questao " + i + " da prova mesclada";
                k = rnd.Next(enunciadosProvaMescladaDescritivas.Length);
                respostasProvaMesclada[i] = "resposta " + enunciadosProvaMescladaDescritivas[k];
            }
            for (int i = 5; i < 10; i++)
            {
                enunciadoProvaMesclada[i] = "enunciado da questao " + i + " da prova mesclada";
                respostasProvaMesclada[i] = "resposta " + "- " + i;
            }

            Console.WriteLine("prova 4 (prova mesclada)\n");
            int count4 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(enunciadoProvaMesclada[i]);
                Console.WriteLine("alternativa " + alternativas[count4] + " " + respostasProvaMesclada[i]);
                count4++;
                if (count4 == 3)
                {
                    count4 = 0;
                }
            }



        }





        static void Main(string[] args)
        {


            GerarGabarito();
            Console.ReadKey();

        }
    }
}
