using System;
using System.Collections.Generic;
using System.Text;

namespace _03_CSharpIntro
{
    class Loops
    {
        // for loops
        static void ForLoop()
        {
            
            // contador; condição; incremento
            for(int contador = 1; contador < 10; contador++)
            {
                Console.WriteLine(contador);
            }
            Console.Read();
        }

        static void DoWhile(int contador)
        {
            // Primeiro executa, depois checa condição
            do
            {
                Console.WriteLine(contador);
                contador++;
            } while (contador < 5);

            Console.Read();
        }

        static void WhileLoop()
        {
            // Confere condição primeiro, depois executa.
            int contador = 0;
            while(contador < 10)
            {
                Console.WriteLine(contador);
                contador++;
            }
            Console.Read();
        }

        static void BreakEContinue()
        {

            // break termina o loop
            for (int contador = 0; contador < 0; contador++)
            {
                Console.WriteLine(contador);
                if (contador == 3)
                {
                    Console.WriteLine("No 3 paramos de contar!");
                    break;
                }
            }
            Console.Read();

            // Continue pula o passo
            for (int contador = 0; contador < 0; contador++)
            {
                Console.WriteLine(contador);
                if (contador == 3)
                {
                    Console.WriteLine("Não escrevemos 3");
                    continue;
                }
            }
            Console.Read();
        }

    }
}
