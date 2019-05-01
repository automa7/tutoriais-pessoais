using System;

namespace _03_CSharpIntro
{
    class Classe
    {
        // Classes são plantas de objetos
        // Possuem membros, que são variaveis especificas dela
        // Essas váriaveis podem ser privadas ou públicas
        // Privadas só são utilizadas pela classe, e são protegidas contra novas atribuições
        public string PrimeiroNome;
        private string Sobrenome = "Lopes";

        // Métodos são as funções que o objeto pode executar, e também podem ser públicas ou privadas.
        public void Introduzir()
        {
            Console.WriteLine("Meu nome é {0} {1}", PrimeiroNome, Sobrenome);
            Console.Read();
        }

        private void Processar()
        {
            Console.WriteLine("Não pode ser chamado fora do escopo da classe.");
            Console.Read();
        }
    }

    class Exercicio
    {
        public void Main(string[] args) 
        {
            Classe objeto = new Classe
            {
                PrimeiroNome = "Alex" // atribui o nome para o objeto
            };
            // objeto.Sobrenome = 'Silva'; // não funciona

            objeto.Introduzir(); // executa o método de introdução com o nome atribuido para o objeto.

            // objeto.Processar(); // não funciona

        }
    }

    class Construtor
    {
        // Um construtor funciona como um processamento que pode ser feito na inicialização da classe
        // Ele é executado quando você executa Classe Variavel = new Classe()
        // Ele é declarado da seguinte forma:
        
        // É feito inicialment a declaração das variaveis da classe
        public string primeiroNome;
        public string sobreNome;

        // Em seguida, é feito a declaração da função construtora; 
        // Note que as variaveis primeiroNome e sobreNome possuem o mesmo nome das variaveis
        // da classe, porém são argumentos locais da função Construtor, e não fogem desse escopo;
        // Para atribuir os valores delas para variaveis globais, é necessário utilizar o método
        // "this", como mostrado abaixo:
        public Construtor(string primeiroNome, string sobreNome)
        {
            this.primeiroNome = primeiroNome;
            this.sobreNome = sobreNome;
        }

        // Pode-se ter vários construtores, que são escolhidos de acordo com os parametros que são passados na inicialização da classe;
        public Construtor()
        {
            // Esse construtor é utilizado se o objeto for inicializado sem definir parametros.
            Console.WriteLine("Construtor vazio chamado.");
        }
    }

    class Propriedades
    {
        // Propriedades são métodos que permitem aplicar uma camada de segurança a variaveis privadas,
        // Criando uma interface para altera-las. 
        // Elas podem ser chamadas da seguinte forma: 
        private double peso; 

        public double Peso
        {
            get
            {
                return Peso;
            }
            set
            {
                peso = value;
            }
        }

        // Ou podem ser criadas independentemente:
        public int Idade { get; set; }

        // Por convenção, propriedades devem começar com letras maiusculas. 

        // Um dos motivos para se utilizar propriedades é permitir o tratamento do valor definido durante a atribuição:
        private int livros_estudados;

        public int Livros
        {
            get
            {
                return livros_estudados;
            }
            set
            {
                if (value < 0) throw new Exception("Valor não pode ser negativo");
                livros_estudados = value;
            }
        }

        // É possivel reduzir o código de interface também:
        public double Peso2
        {
            get => peso;
            set => peso = value;
        }


    }
}

