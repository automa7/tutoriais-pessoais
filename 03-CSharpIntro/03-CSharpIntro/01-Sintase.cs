// Comentários podem ser feitos em uma linha 

/* ou em multiplas linhas 
 * utilizando 
 * esse modelo */

using System; // importação de "pacotes" de classes são feitas com o comando using

namespace SintaseBasica // name space são "containers", e definem um nível superior de escopo
{
    class Sintase // Classes são definidas dessa maneira

    { // chaves são postas abaixo da linha de definição para separação do código

        static void Main(string[] args) // metodos são definidos utilizando esse formato
        {
            /* Console é uma classe contida em System, 
             * e permite manipular um console windows
             * efetuando atividades como escrever, mudar
             * tamanho da janela e mais */
            Console.SetWindowSize(200, 40);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear(); // efetua aplicação da cor para todo o terminal
            Console.WriteLine("Hello Dude");
            Console.WriteLine("This is another line");
            Console.Read(); // efetua apresentação do WriteLine na execução do app.
        }
    }
}
