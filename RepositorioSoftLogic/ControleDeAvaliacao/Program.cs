using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAvaliacao
{
    class Program
    {
        public static string User = "Thiago";
        public static string Senha = "thiago123";
        public static int OpcaoMenu;
        public static int QuestoesObjetivas;
        public static int QuestoesDescritivas;
        public static int TotalDeQuestoes;
        public static string[,] Alternativas;
        public static int codigo;
        public static string[] respostas;
        public static string[] EnunciadosObjetivas;
        public static string[] EnunciadosDescritivas;

        static void Main(string[] args)
        {
            bool status = false;
            int tentativasErradas = 0;
            do
            {
                status = VerificarCredenciais();
                if (!status)
                {
                    Console.Clear();
                    Console.WriteLine("=========================== ATENÇÃO! ===========================");
                    Console.WriteLine("\n\n\n\n\n\n\n\n");
                    Console.WriteLine("ATENÇÃO: Nome de usuário e senha não conferem! Verifique-os.\n \nAperte ENTER para continuar");
                    tentativasErradas++;
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("=========================== HOME ===========================");
                    Console.WriteLine("\n\n\n\n\n");
                    Console.Write("SUCESSO! Você está logado!\n\n\n\n\nAperte ENTER para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }

                if (tentativasErradas == 3)
                {
                    Console.Clear();
                    Console.WriteLine("=========================== ATENÇÃO! ===========================");
                    Console.WriteLine("\n\n\n\n\n\n\n\n ");
                    Console.WriteLine("USUÁRIO BLOQUEADO! \nDados informados incorretamente por 3 vezes seguidas!\n");
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n ");
                    break;
                }
            } while (!status);

            if (!status)
                Console.WriteLine("Tente novamente mais tarde!");
            else
            {
                do
                {
                    Console.Clear();
                    OpcaoMenu = MostrarMenu();
                    switch (OpcaoMenu)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine(" ========== CADASTRO ==========\n");
                            Console.Write("Informe a quantidade de questões descritivas: ");
                            QuestoesDescritivas = int.Parse(Console.ReadLine());
                            Console.Write("Informe a quantidade de questões objetivas: ");
                            QuestoesObjetivas = int.Parse(Console.ReadLine());
                            TotalDeQuestoes = QuestoesDescritivas + QuestoesObjetivas;
                            if (QuestoesDescritivas > 0 && QuestoesObjetivas > 0)
                            {
                                EnunciadosObjetivas = CadastroDeEnunciadosDeQuestoesObjetivas(QuestoesObjetivas);
                                Alternativas = CadastraAlternativasDaprova(QuestoesObjetivas);
                                EnunciadosDescritivas = CadastroDeEnunciadosDeQuestoesDescritivas(QuestoesDescritivas);
                                codigo = 3;
                            }
                            if (QuestoesDescritivas > 0 && QuestoesObjetivas == 0){
                                 EnunciadosDescritivas = CadastroDeEnunciadosDeQuestoesDescritivas(QuestoesDescritivas);
                                codigo = 2;
                            }
                            if (QuestoesDescritivas == 0 && QuestoesObjetivas > 0)
                            {
                                EnunciadosObjetivas = CadastroDeEnunciadosDeQuestoesObjetivas(QuestoesObjetivas);
                                Alternativas = CadastraAlternativasDaprova(QuestoesObjetivas);
                                codigo = 1;
                            }
                            if (QuestoesDescritivas == 0 && QuestoesObjetivas == 0)
                            {
                                Console.WriteLine("ATENÇÃO: Quantidade Incorreta!");
                            }
                            break;
                        case 2:
                            respostas = GerarGabarito(QuestoesObjetivas, QuestoesDescritivas);
                            break;
                        case 3:
                            Console.Clear();
                            if(QuestoesObjetivas > 0){
                                ImprimiEnunciadoObjetivas(EnunciadosObjetivas, Alternativas);                                
                            }
                            if (QuestoesObjetivas == 0)
                            {
                                Console.WriteLine("Atenção: não há objetivas");
                            }
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Clear();
                           if(QuestoesDescritivas > 0){
                               ImprimiEnunciadosDescritivas(EnunciadosDescritivas);
                           }
                           if (QuestoesDescritivas == 0)
                           {
                               Console.WriteLine("Atenção: não há descritivas");
                           }
                           Console.ReadKey();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("=========================== SAINDO ===========================");
                            Console.WriteLine("\n\n\n\n\n\n\n\n ");
                            Console.WriteLine("ATÉ LOGO!");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("ATENÇÃO: Opção Inválida! \nPressione ENTER para continuar.");
                            Console.ReadKey();
                            break;
                    }
                } while (OpcaoMenu != 5);
            }
            Console.ReadKey();
        }

        public static int MostrarMenu()
        {
            Console.WriteLine("=========================== MENU ===========================");
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.WriteLine("1 - Cadastrar Prova (Opcional)");
            Console.WriteLine("2 - Gerar Gabarito");
            Console.WriteLine("3 - Imprimir Enunciados Objetivas");
            Console.WriteLine("4 - Imprimir Enunciados Descritivas");
            Console.WriteLine("X - Sobre (Nomes da equipe e nome da empresa)");
            Console.WriteLine("5 - Encerrar o programa.");
            Console.WriteLine("\n\n\n\n\n\n\n\n");
            Console.Write("Informe a opção desejada: ");
            return int.Parse(Console.ReadLine());
        }

        public static bool VerificarCredenciais()
        {
            Console.Clear();
            Console.WriteLine(" =========================== LOGIN ===========================");
            Console.WriteLine("\n\n");
            Console.Write("Informe o nome de usuário: ");
            string nameUser = Console.ReadLine();
            Console.Write("Informe a senha: ");
            string senhaUser = Console.ReadLine();
            if (nameUser.ToUpper() == User.ToUpper() && Senha == senhaUser)
                return true;
            else
                return false;
        }

        static void MostrarOpcoesAjuda()
        {
            Console.WriteLine("1 - Cadastro \n2 - Consultas \n3 - Retornar ao Menu Inicial");
        }

        static void MostrarSobre()
        {
            Console.Clear();
            Console.WriteLine(" ===== SOBRE =====\n");
            Console.WriteLine("Nome do Programa: CONTROLE DE AVALIAÇÕES");
            Console.WriteLine("Empresa: SOFTLOGIC");
            Console.WriteLine("\n ===== Equipe de Desenvolvimento =====\n \n- ARNALDO MADEIRA \n- CAMILA SILVA \n- LUCAS SIQUEIRA \n- RAFAEL ALDO");
            Console.Write("\nPressione ENTER para continuar: ");
            Console.ReadKey();
        }

        static void MostrarAjuda()
        {
            int opcaoMenuAjuda = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(" ===== AJUDA =====");
                MostrarOpcoesAjuda();
                Console.Write("\nInforme a opção desejada: ");
                opcaoMenuAjuda = int.Parse(Console.ReadLine());
                switch (opcaoMenuAjuda)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(" ===== AJUDA - CADASTRO ===== \n");

                        string qObjetivas = "\nQuestões objetivas são as questões que possuem 5 alternativas corretas (A,B,C,D,E) que possuem apenas uma alternativa correta";
                        string qDescritivas = "\nQuestões descritivas: são questões abertas. Ou seja, são perguntas onde você \nterá que ESCREVER as respostas.";
                        Console.WriteLine("1 - Tipos de questões: \n{0}\n{1}", qObjetivas, qDescritivas);

                        string instrucoesCadastro = "Para cadastrar uma prova, inicialmente o usuário deve informar a \nquantidade de questões descritivas e de questões objetivas.";
                        string instrucoesCadastro2 = "Em seguida, o usuário irá informar o enunciado das questões descritivas e das questões objetivas";
                        string instrucoesCadastro3 = "A próxima etapa consiste em cadastrar a descrição das alternativas que \npertencem as questões objetivas";
                        Console.WriteLine("\n2 - Cadastrar: \n \n2.1 - {0}\n2.2 - {1}\n2.3 - {2}\n", instrucoesCadastro, instrucoesCadastro2, instrucoesCadastro3);

                        string instrucoesGabarito = "O primeiro passo da geração de gabarito é informar qual é a alternativa \ncorreta das questões objetivas";
                        string instrucoesGabarito2 = "Após isso, basta informa quais são as respostas para ser ter base na \ncorreção das questões descritivas. \n3.3 - Com todas essas etapas feitas, o programa irá exibir na tela o gabarito \n(Questão e sua respectiva resposta)";
                        Console.WriteLine("\n3 - Gabarito: \n \n3.1 - {0} \n3.2 - {1}", instrucoesGabarito, instrucoesGabarito2);

                        Console.WriteLine("\nPressione a tecla ENTER para continuar: ");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(" ===== AJUDA - CONSULTA ===== \nAperte ENTER para continuar");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Aperte ENTER para continuar");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.Write("ATENÇÃO! Opção Inválida \nAperte ENTER para continuar");
                        Console.ReadKey();
                        break;
                }
            } while (opcaoMenuAjuda != 3);
        }

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

        public static void ImprimiEnunciadoObjetivas(string[] array, string[,] array2)
        {
            Console.WriteLine("enunciados objetivas");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }
            ImprimiAlternativasQuestoesObjetivas(array2);
        }

        public static void ImprimiAlternativasQuestoesObjetivas(string[,] array)
        {

            char[] letras = new char[5];
            letras[0] = 'A';
            letras[1] = 'B';
            letras[2] = 'C';
            letras[3] = 'D';
            letras[4] = 'E';

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("alternativas da questão:{0}", i);
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("alternativa:{0}", letras[j]);
                    Console.WriteLine(array[i, j]);
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

    }
}
