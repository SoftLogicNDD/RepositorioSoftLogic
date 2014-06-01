using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lucas
{
    class Program
    {


        public static int QuestoesObjetivas;
        public static int QuestoesDescritivas;
        public static int TotalDeQuestoes;

        public static string[] CadastroDeEnunciadosDeQuestoesObjetivas(int QuestoesObjetivas)
        {

            string[] enunciadosObjetivas = new string[QuestoesObjetivas];

            if (QuestoesObjetivas > 0)
            {

                
                for (int i = 0; i < QuestoesObjetivas; i++)
                {
                    Console.Clear();
                    Console.WriteLine("\n===== Cadastro de Questões Objetivas =====");
                    Console.WriteLine("\nDigite o enunciado das questão objetiva {0}: ", i);
                    int j = 0;
                    enunciadosObjetivas[i] = Console.ReadLine();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("===== Cadastro de Questões Objetivas =====");
                Console.WriteLine("Não há questões objetivas para cadastro!");
            }
            return enunciadosObjetivas;
        }

        public static string[] CadastroDeEnunciadosDeQuestoesDescritivas(int QuestoesDescritivas)
        {
            string[] enunciadosDescritivas = new string[QuestoesDescritivas];
            if (QuestoesDescritivas > 0)
            {
                for (int i = 0; i < QuestoesDescritivas; i++)
                {
                    Console.Clear();
                    Console.WriteLine("===== Cadastro de Questões Descritivas =====");
                    Console.WriteLine("\nDigite o enunciado da questão descritiva {0}: ", i);
                    int j = 0;
                    enunciadosDescritivas[i] = Console.ReadLine();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("===== Cadastro de Questões Descritivas =====");
                Console.WriteLine("Mão há questões descritivas para cadastro!");
            }
            return enunciadosDescritivas;
        }

        public static string[,] CadastraAlternativasDaprova(int QuestoesObjetivas)
        {
            string[] alternativas = new string[QuestoesObjetivas];
            string[,] todasAlternativas = new string[QuestoesObjetivas, 5];
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
                    Console.WriteLine("===== Cadastro de Alternativas =====");
                    Console.WriteLine("Digite a descrição da alternativa {0}, da questão {1}: ", letras[j], i);
                    alternativas[i] = Console.ReadLine();
                    todasAlternativas[i, j] = alternativas[i];
                }
                Console.Clear();
            }
            return todasAlternativas;
        }

        public static string[] GerarGabarito(int QuestoesObjetivas, int QuestoesDescritivas)
        {
            Console.Clear();
            Console.WriteLine("===== Gabarito =====");
            string[] alternativaCerta = new string[QuestoesObjetivas];
            string[] RespostaCertaDescritiva = new string[QuestoesDescritivas];
            string[] todasResposta = new string[QuestoesDescritivas + QuestoesObjetivas];
            for (int i = 0; i < QuestoesObjetivas; i++)
            {
                Console.WriteLine("Cadastro de respostas das questoes objetivas");
                Console.WriteLine("Qual é a alternativa certa da questão {0}: ", i);
                alternativaCerta[i] = Console.ReadLine();
            }
            for (int i = 0; i < QuestoesDescritivas; i++)
            {
                Console.WriteLine("Cadastro das respostas das questoes descritivas");
                Console.WriteLine("Digite a resposta descritiva certa da questão {0}: ", i);
                RespostaCertaDescritiva[i] = Console.ReadLine();
            }
            for (int i = 0; i < QuestoesObjetivas; i++)
            {
                todasResposta[i] = alternativaCerta[i];
            }
            int count = 0;
            for (int i = QuestoesObjetivas; i < TotalDeQuestoes; i++)
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
            int t;
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

        public static void ImprimirEnunciadoObjetivas(string[] array, string[,] array2)
        {
            char[] letras = new char[5];
            letras[0] = 'A';
            letras[1] = 'B';
            letras[2] = 'C';
            letras[3] = 'D';
            letras[4] = 'E';
            Console.WriteLine(" ===== QUESTÕES OBJETIVAS =====\n");
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                Console.WriteLine("Questão {0}: {1}", i, array[i]);
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    if (array2[i, 0] == null)
                    {
                        Console.WriteLine("questão:{0} deletada", i);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Alternativa {0}: {1}", letras[j], array2[i, j]);
                    }



                }
                Console.WriteLine(" ");
            }


            Console.WriteLine("Pressione ENTER para continuar: ");

        }
        public static void ImprimirAlternativasQuestoesObjetivas(string[,] array)
        {

            char[] letras = new char[5];
            letras[0] = 'A';
            letras[1] = 'B';
            letras[2] = 'C';
            letras[3] = 'D';
            letras[4] = 'E';

            for (int i = 0; i < array.GetLength(0); i++)
            {


                Console.WriteLine("Alternativas da questão:{0}", i);
                for (int j = 0; j < array.GetLength(1); j++)
                {


                    Console.WriteLine("Alternativa :{0} {1}", letras[j], array[i, j]);



                }
            }
        }
        
        public static void ImprimiEnunciadosDescritivas(string[] array)
        {
            Console.WriteLine("enunciados descritivas");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }

        public static void ImprimirGabarito(string[] array, int tipo)
        {

            if (tipo == 1)
            {
                Console.Clear();
                Console.WriteLine("Respostas Questões Objetivas:");
                for (int i = 0; i < QuestoesObjetivas; i++)
                {
                    Console.WriteLine("questao:{0}", i);
                    Console.WriteLine(array[i]);
                }
            }
            if (tipo == 2)
            {
                Console.Clear();
                Console.WriteLine("respostas questoes descritivas:");
                for (int i = 0; i < QuestoesDescritivas; i++)
                {
                    Console.WriteLine("questao:{0}", i);
                    Console.WriteLine(array[i]);
                }
            }
            if (tipo == 3)
            {
                Console.Clear();
                Console.WriteLine("respostas de todas as questoes:");
                Console.WriteLine("respostas das questoes objetivas:");
                for (int i = 0; i < QuestoesObjetivas; i++)
                {
                    Console.WriteLine("questao:{0}", i);
                    Console.WriteLine(array[i]);
                }

                Console.WriteLine("respostas das questoes descritivas:");
                for (int i = QuestoesObjetivas; i < TotalDeQuestoes; i++)
                {
                    Console.WriteLine("questao:{0}", i);
                    Console.WriteLine(array[i]);
                }
            }
        }

       
        public static void RemoveResposta(int posicao, string[] array)
        {
            if (!VerificaPosicao(posicao))
            {
                Console.WriteLine("Posição inválida");

                }
            for (int i = posicao; i < TotalDeQuestoes - 1; i++)
            {

                array[i] = array[i + 1];
            }
            TotalDeQuestoes--;
        }


        public static bool VerificaPosicao(int posicao)
        {
            return posicao >= 0 && posicao <= TotalDeQuestoes;
        }

        public void RemoveEnunciado(int posicao,string []array)
        {
            if (!VerificaPosicao(posicao))
            {
                Console.WriteLine("Posição inválida");
               
            }
            for (int i = posicao; i < TotalDeQuestoes - 1; i++)
            {
               array[i] = array[i + 1];
            }
           TotalDeQuestoes--;
        }
        public static void RemoveEnunciado(int posicao, string[] array, string[,] alternativas)
        {
            if (!VerificaPosicao(posicao))
            {
                Console.WriteLine("Posição inválida");
            }
            array[posicao] = null;

            for (int j = 0; j < alternativas.GetLength(1); j++)
            {
                alternativas[posicao, j] = null;
            }



            TotalDeQuestoes--;
            Console.WriteLine("Aperte ENTER para continuar: ");
        }



      
        public static void EditarEnunciado(string[] array, int pos)
        {
            if (VerificaPosicao(pos))
            {
                Console.WriteLine("Enunciado antigo: {0}", array[pos]);
                Console.WriteLine("Informe o enunciado novo: ");
                array[pos] = Console.ReadLine();
                Console.WriteLine("Novo Enunciado: {0}", array[pos]);
            }
            else
            {
                Console.WriteLine("ATENÇÃO: Posição é inválida!");
            }

        }
        public static bool VerificaPosicao(string[] array, int posicao)
        {
            return array[posicao] == null;
        }

        public static void EditarAlternativa(string[] array, int pos)
        {
            if (VerificaPosicao(pos))
            {
                array[pos] = Console.ReadLine();
            }

        }
        public static void EditarResposta(string[] array, int pos)
        {
            if (VerificaPosicao(pos))
            {
            array[pos] = Console.ReadLine();
        }
        }

        

       
    }

}
