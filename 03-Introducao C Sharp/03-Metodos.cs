using System;
using System.Collections.Generic;
using System.Text;

namespace _03_CSharpIntro
{
    class Metodos
    {
        /*Estrutura de um metodo:
        *  <Especificador de Acesso> <Tipo de Retorno> <Nome>(Lista de Parametreos)
        * { Corpo }
        * Especificador de acesso: determina visibilidade do método
        * Tipo de retorno: void  para sem retorno, ou tipo de dado que será retornado (string, int, etc) 
        * 
        */

        // Método com retorno
        public static int Soma(int num1, int num2)
        {
            return num1 + num2;
        }

        // Main é o método principal da classe
        static void Main(String[] args)
        {

            Console.WriteLine(Soma(1, 2)); // Só é possível chaamr o método porque ele está definido como estatico
            Console.Read();

            EscreveUmaFrase("Um Frase Escrita"); // É possivel chamar métodos declarados depois do Main normalmente

        }

        // Método sem retorno
        public static void EscreveUmaFrase(string frase)
        {
            Console.WriteLine(frase);
            Console.Read();
        }

        // Métodos com input de usuário
        static void Input(string[] args)
        {

            Console.WriteLine("Escreva uma informação: ");
            string input = Console.ReadLine(); // função readline aceita input
            Console.WriteLine("Você escrever: " + input);
            Console.Read();

        }

        // Métodos Try, Catch e Finally
        static void TryECatch(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            string input = Console.ReadLine();

            // Para garantir que a conversão de string para numero não apresente erro, utilizamos Try Catch
            try // tenta executar o código
            {
                int num1 = int.Parse(input);
            }
            catch (FormatException) // se um erro ocorrer, catch é ativado. Exception ativa qualquer erro, mas é possivel especificar
            {
                Console.WriteLine("Formato Errado, por favor entre o tipo correto");
            }
            catch (Exception) // podemos criar quantos catch necessários
            {
                Console.WriteLine("Erro indefinido ocorreu.");
            }
            finally // código ativado após try ou catch, indepedente de qual é ativado
            {
                Console.WriteLine("Isso sempre é chamado");
                // Pode ser usado para coisas como fechar conexão de dados;
            }

        }

        // Métodos operadores e comparativos
        static void Operadores(string[] args)
        {
            int num1 = 5;
            int num2 = 42;
            int num3;

            // operadores unários
            num3 = -num1; // -1 * num1

            bool verdade = true;
            verdade = !verdade; // equivalente a "não é" para booleanos, resultado aqui é false

            // operadores incrementais
            num3++; // num3 + 1
            num3--; // num3 - 1

            Console.WriteLine("Se ativarmos o ++ depois da variavel, ele só incrementa na proxima execução: {0}", num3++);
            Console.WriteLine(num3);
            Console.WriteLine("Para incrementar na mesma execução, utiliza-se o ++ antes da váriavel: {0}", ++num3);

            // Operadores relacionais
            bool menor = num1 < num2;
            bool maior = num2 > num1;
            bool menor_ou_igual = num1 >= num3;
            bool maior_ou_igual = num3 <= num1;
            bool igual = num3 == num1;
            bool diferente = num1 != num2;

            // Operadores Condicionais
            bool e = menor && maior;
            bool ou = igual || diferente;

            // Condição se e se não
            if (e) 
            {
                Console.WriteLine("Verdadeiro");
            } else if(!e)
            {
                Console.WriteLine("Falso");
            }
            else
            {
                Console.WriteLine("Falso");
            }

            // Método switch para condição se
            string idade = Console.ReadLine();

            switch(idade)
            {
                case "15":
                    Console.WriteLine("Muito novo");
                    break; // break é obrigatório para sair do switch
                case "25":
                    Console.WriteLine("Muito Velho");
                    break;
                default: // default é a resolução padrão caso nenhuma condição seja atendida
                    Console.WriteLine("Ok");
                    break;
            }

            // Condição Se ternária
            int temperatura = 15;
            string estado;

            // Se temperatura abaixo de 0 então Estado = "Liquido", se não, "Solido"
            estado = temperatura < 0 ? "Liquido" : "Solido";
            // É possivel multiplas condições
            estado = temperatura < 0 ? "Liquido" : temperatura > 100 ? "Gasoso" : "Solido";

            Console.Read();

        }
            
    }
}
