using System;
using System.Collections.Generic;
using System.Text;

namespace _03_CSharpIntro
{
    public class Variaveis
    {
        /* Variáveis precisam ser definidas 
         * utiliza-se também o comando static para determinar que 
         * uma variavel é estática e pode ser utilizada em um 
         * método estático
         */
        static int idade = 15; // int é int32
        int idade2; // valor padrão de int sem atribuição é 0
        short a; // short é int16
        long b; // long é int64

        float c = 99.99F; // é float32, se não utilizar o f na atribuição do valor é entendido como double
        double x = 1.5; // Double é float64
        decimal y = 1.5M; // Decimal é float128, é necessário utilizar o M no final

        // Variaveis texto
        char UmaLetra = 'A'; // uma aspa representa uma unidade de código UTF-16
        string StringPadrao = "String possui vários caracteres"; // usar aspa dupla para string

        // Valores Booleanos
        bool verdade = true;
        bool falso = false;

        public static void VariaveisBasicas(string[] args)
        {
            idade = 20; // variaveis do escopo de fora podem ser usadas dentro do escopos interiores

            /* idade2 e as outras variaveis não podem ser utilizadas nesse método
             pois ele está definido como estatico
             Para utiliza-los, é necessário retirar o static do método ou adicionar
             static nas váriaveis */

            Console.WriteLine(idade);
            Console.WriteLine("Strings e " + idade + " podem ser concatenados sem definir tipo str" +
                "para a variavel");

            String mensagem1 = "Concatenação também funciona";
            String mensagem2 = mensagem1 + " na atribuição de váriaveis string.";

            // variaveis string são tratadas como objetos e possuem métodos 
            Console.WriteLine(mensagem2.ToUpper()); // apresenta mensagem toda em CAPSLOCK

            float d1 = 1.5F;
            double d2 = 3.2;
            decimal d3 = 2.5M;

            // numeros também possuem métodos
            string d1_txt = d1.ToString();

            /* você pode  efetuar operações matematicas apenas com o mesmo tipo de váriavel
             para utilizar operações entre os tipos de váriaveis, é necessário utilizar cast
             por exemplo: */
            // float soma = d1 + d2; // não funciona
            float soma = d1 + (float)d2; // funciona

            /* definir o tipo de convresão entre parenteses antes da variavel é considerado
             * uma conversão explicita. Uma conversão implicita é a conversão de um tipo menor
             para um maior, como int32 para int64: */
            int num = 32;
            long numGrande = num;

            float peqnum = 13.36F;
            double grandenum = peqnum;

            // numero para string é feito através do método .ToString apresentado antes
            string txtnum = grandenum.ToString();

            // texto para numero
            string num1 = "15";
            string num2 = "32";

            // utiliza-se o objeto int32 e o método Parse para conversão
            int numero1 = Int32.Parse(num1);
            int numero2 = Int32.Parse(num2);
            // Se algum valor invalido for passado para o Parse, um erro Exceção ocorrerá
            // método TryParse pode ser usado para retornar um booleano do resultado 
            int resultado = numero1 + numero2;


            Console.Read();
        }

        public static void Constantes(string[] args)
        {
            // Constantes são campos imutaveis definidos com o comando const
            // Pode ser de qlq tipo
            const double PI = 3.14159265359;
            const int num1 = 42;
            const string nome = "Seu Nome";

            void Main(string[] args)
            {
                Console.WriteLine(nome + " é uma constante.");

            }
        }
    }
}
