using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Lista3
{
    class ListaTodas
    {
        static List<int> matriculas = new List<int>();
        static void Main(string[] args)
        {
            int op;

            Console.WriteLine(" ============ Lista 4 - Listas ============");
            #region Escolha

            Console.WriteLine($"{Environment.NewLine}Escolha o exercício que você quer ver: {Environment.NewLine}" +
                $"1. A {Environment.NewLine}" + //OK
                $"2. B {Environment.NewLine}" + //OK
                $"3. C {Environment.NewLine}" + //OK
                $"4. (Exercício 1) {Environment.NewLine}" + //OK
                $"5. (Exercício 2) {Environment.NewLine}" + //OK
                $"6. (Exercício 3) {Environment.NewLine}" + //OK
                $"7. (Exercício 4) {Environment.NewLine}" +
                $"8. (Exercício 5) {Environment.NewLine}" +
                $"9. (Exercício 6) {Environment.NewLine}" +
                $"10. Exemplo de inverter ordem do vetor. ");
            op = Convert.ToInt32(Console.ReadLine());
            #endregion

            switch (op)
            {
                case 1:     //feito
                    Console.Write("Quantas entradas deseja? ");
                    int numEntrada = Convert.ToInt32(Console.ReadLine());
                    List<int> lista1 = LerNumeros(numEntrada);
                    ImprimirNumeros(lista1);
                    break;
                case 2:     //feito
                    List<int> lista2 = LerEntradas();
                    ImprimirEntradas(lista2);
                    break;
                case 3:     //feito
                    List<int> lista3 = LerAleatorio();
                    ImprimirAleatorio(lista3);
                    break;
                case 4:     //feito
                    List<int> lista4 = LerDezListas(10);
                    ImprimirEntradas(lista4);
                    break;
                case 5:     //feito
                    List<int> lista5 = LerMatriculas(10);
                    ImprimirNumeros(lista5);
                    break;
                case 6:     //feito
                    Console.Clear();
                    List<int> dados = new List<int>();
                    int numero = 0;

                    do
                    {
                        Console.WriteLine("Entre com um valor: ");
                        numero = Convert.ToInt32(Console.ReadLine());
                        dados.Add(numero);
                    } while (numero != 999);

                    dados.RemoveAt(dados.Count - 1);
                    int[] vetorInvertido = new int[dados.Count];

                    for (int i = dados.Count - 1; i >= 0; i--)
                    {
                        vetorInvertido[(dados.Count - 1) - i] = dados[i];
                    }

                    Console.WriteLine($"{Environment.NewLine}----------- Números invertidos: -----------");

                    foreach (var num in vetorInvertido)
                    {
                        Console.WriteLine(num);
                    }

                    break;
                case 7:     //feito
                    List<int> lista7 = LerMatriculasEx7(10);
                    ValidarMatricula(lista7);
                    break;
                case 8: //feito
                    Console.Clear();
                    NotasProvas();
                    break;
                case 9:
                    Console.Clear();
                    List<int> lista9 = LerDezListas(10);
                    SomaImpar(lista9);
                    break;

                case 10: //exemplo
                    Console.WriteLine("Entre com uma frase ou palavra: ");
                    var entrada = Console.ReadLine();
                    List<char> invertido = new List<char>(entrada.ToCharArray());
                    invertido.Reverse();

                    foreach (var c in invertido)
                        Console.Write(c);
                    break;
            }
            Console.WriteLine($"{Environment.NewLine}Aperte qualquer tecla para encerrar o programa. ");
            Console.ReadKey();
        }
        public static List<int> LerMatriculas(int num)
        {
            Console.Clear();
            List<int> Matriculas = new List<int>();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Entre com a matrícula {i + 1}: ");
                int novaMatricula = Convert.ToInt32(Console.ReadLine());

                if (ValidarMatricula(novaMatricula, Matriculas))
                {
                    Matriculas.Add(novaMatricula);
                }
                else
                    i--;
            }
            return Matriculas;
        }

        private static bool ValidarMatricula(int novaMatricula, List<int> matriculas)
        {
            Console.Write("Digite uma matrícula para verificar se está presente na lista: ");
            int matricula = int.Parse(Console.ReadLine());
            if (VerificarMatricula(matricula))
            {
                Console.WriteLine($"A matrícula {matricula} está presente na lista.");
            }
            else
            {
                Console.WriteLine($"A matrícula {matricula} não está presente na lista.");
            }
            return true;
        }

        private static void SomaImpar(List<int> lista9)
        {
            throw new NotImplementedException();
        }

        //exercício A - case 1
        public static List<int> LerNumeros(int numeroDeLeituras, string msg = "Entre com o valor da entrada: ")
        {
            Console.Clear();
            int i = 0;

            List<int> numeros = new List<int>();

            for (i = 0; i < numeroDeLeituras; i++)
            {
                Console.WriteLine(msg);
                numeros.Add(Convert.ToInt32(Console.ReadLine()));
            }

            return numeros;
        }

        public static void ImprimirNumeros(List<int> numeros)
        {
            Console.WriteLine("Números lidos:");
            int i = 1;

            foreach (int num in numeros)
            {
                Console.WriteLine("Entrada "+ (i++) + ": " + num + " ");
            }
        }
        //exercício B - case 2
        public static List<int> LerEntradas()
        {
            Console.Clear();
            int tam;

            Console.WriteLine("Infome um valor para a quantidade de entradas: ");
            tam = Convert.ToInt32(Console.ReadLine());

            List<int> listaEntradas = new List<int>();

            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine($"Infome um valor inteiro para a posição {i + 1}: ");
                listaEntradas.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return listaEntradas;
        }

        public static void ImprimirEntradas(List<int> listaNumeros)
        {
            for (int i = 0; i < listaNumeros.Count; i++)
            {
                Console.WriteLine($"=== Valores informados === {Environment.NewLine}Posição {i + 1}: {listaNumeros[i]}");
            }
        }

        //exercício C - case 3
        public static List<int> LerAleatorio()
        {
            Console.Clear();
            int qtdEntrada;

            Console.WriteLine($"Informe quantos valores você quer gerar aleatóriamente: ");
            qtdEntrada = Convert.ToInt32(Console.ReadLine());

            List<int> listaLer = new List<int>();

            for (int i = 0; i < qtdEntrada; i++)
            {
                Random random = new Random();
                int valorAleatorio = random.Next(1, 101); // Gera um valor aleatório entre 1 e 100
                listaLer.Add(valorAleatorio);
            }

            return listaLer;
        }

        public static void ImprimirAleatorio(List<int> listaAleatoria)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < listaAleatoria.Count; i++)
            {
                int numero = r.Next(0, 100); // Gera um número aleatório entre 0 e 100
                Console.WriteLine($"Valores gerados aleatóriamente: {Environment.NewLine}{i + 1}º: {numero}");
            }
        }

        //Exercício 1 - case 4
        public static List<int> LerDezListas(int num = 10)
        {
            Console.Clear();
            List<int> listaValores = new List<int>();

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Entre com o valor {i + 1}: ");
                listaValores.Add(Convert.ToInt32(Console.ReadLine()));
            }

            return listaValores;
        }

        //Exercício 2 - case 5 (reutilizável no exercíco 4)
        static int LerMatriculasEx7()
        {
            int matricula;
            Console.WriteLine("Digite as matrículas dos alunos:");
            for (int i = 0; i < 10; i++)
            {
                matricula = int.Parse(Console.ReadLine());
                matriculas.Add(matricula);
            }
            return 0;
        }

        public static void ValidarMatricula(List<int> matriculas, int novaMatricula)
        {
            foreach (int matricula in matriculas)
            {
                if (matricula.ToString().Length != 6)
                {
                    Console.WriteLine($"A matrícula {matricula} é inválida.");
                    continue;
                }

                int soma = 0;
                for (int i = 0; i < 6; i++)
                {
                    soma += int.Parse(matricula.ToString()[i].ToString()) * (i + 1);
                }

                if (soma % 10 == 0)
                {
                    Console.WriteLine($"A matrícula {matricula} é válida.");
                }
                else
                {
                    Console.WriteLine($"A matrícula {matricula} é inválida.");
                }
            }
        }

        //exercício 3 - case 6 não consegui fazer.
        public static List<int> LerExercicio3()
        {
            Console.Clear();
            int qtdEntrada;

            Console.WriteLine($"Informe quantos valores você quer: ");
            qtdEntrada = Convert.ToInt32(Console.ReadLine());

            List<int> listaLer = new List<int>(qtdEntrada);

            for (int i = 0; i < qtdEntrada; i++)
            {
                Console.WriteLine($"Entre com o {i + 1}º valor: ");
                int valor = Convert.ToInt32(Console.ReadLine());
                listaLer.Add(valor);
            }

            return listaLer;
        }

        private static void If999(List<int> tam)
        {
            int lerAuxiliar;
            Random r = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < tam.Count - 1; i++)
            {
                Console.WriteLine($"Escreva um valor para a posição {i + 1}");
                lerAuxiliar = Convert.ToInt32(Console.ReadLine());
                List<int> listAux = new List<int>(lerAuxiliar);
            }
        }

        //inverter a ordem de um vetor
        public static List<char> InverterOrdem(List<char> listaChar)
        {
            List<char> listaRetorno = new List<char>(listaChar.Count);

            for (int i = listaChar.Count - 1; i >= 0; i--)
            {
                listaRetorno.Add(listaChar[i]);
            }

            return listaRetorno;
        }

        public static void InverterOrdemFast(List<char> listaChar)
        {
            int tamanhoLista = listaChar.Count;

            for (int i = 0; i < tamanhoLista / 2; i++)
            {
                int indexOposto = (tamanhoLista - 1) - i;
                char aux = listaChar[i];
                listaChar[i] = listaChar[indexOposto];
                listaChar[indexOposto] = aux;
            }
        }

        //ler 3 notas e colocar em vetor - case 8

        public static void NotasProvas()
        {
            Console.WriteLine("Entre com numero de alunos");
            int numAlunos = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            List<int> mediasAlunos = new List<int>();
            for (int i = 0; i < numAlunos; i++)
            {
                mediasAlunos.Add(MediaProvas());
            }

            for (int i = 0; i < numAlunos; i++)
            {
                Console.WriteLine($"Aluno {i + 1}{Environment.NewLine} Médias: {mediasAlunos[i]}");
            }
        }
        public static int MediaProvas()
        {
            Console.WriteLine("Insira as notas conforme pedido.");

            List<int> notas = new List<int>();
            int media = 0;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Entre com a nota {i + 1}: ");
                notas.Add(Convert.ToInt32(Console.ReadLine()));
            }

            media = (notas[0] + notas[1]) / 2;
            if (media > 5)
                Console.WriteLine("Aprovado! ");
            else
                Console.WriteLine("Reprovado! ");

            return media;
        }

        static bool VerificarMatricula(int Matricula)
        {
            return matriculas.Contains(Matricula);
        }
    }
}