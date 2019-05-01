using System;

/* Nesse aplicativo utilizamos todos os conceitos estudados até aqui 
 * para criarmos um aplicativo simples de calcular médias.
 * Ele eftua alguns tratamentos para erros e calcula apenas médias entre 0 e 10.
 * */
namespace CalculadoraMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int contador = 0;
            float pontos = 0;
            float ponto_holder = 0;

            Console.WriteLine("Calculadora de Média de Pontuação");
            Console.WriteLine("Entre com as pontuações entre 0 e 10, entre com -1 para calcular a média");

            while(ponto_holder != -1)
            {
                Console.WriteLine("Digite a pontuacao:");
                string ponto_str = Console.ReadLine();

                try
                {
                    ponto_holder = float.Parse(ponto_str);
                    if (ponto_holder > 10 | ponto_holder < -1)
                    {
                        Console.WriteLine("Pontuação não permitida, tente novamente;");
                        continue;
                    }
                    pontos += ponto_holder;
                    contador++;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Formato de pontuação incorreto. Tente novamente.");
                    continue;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Nenhuma pontuação foi inserida, por favor insira uma pontuação.");
                    continue;
                }
            }

            float media = pontos / (float)contador;
            Console.WriteLine("A média das pontuações inseridas é: " + media);

            Console.ReadKey();
        }
    }
}
