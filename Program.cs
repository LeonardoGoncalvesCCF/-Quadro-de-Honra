
internal class Program
{
    private static void Main(string[] args)
    {
        // criando um array com tamanho 5 | 0, 1, 2, 3, 4 |
        Pessoas[] pessoas = new Pessoas[5];


        // Loop de coleta de dados
        for (int contador = 0; contador < pessoas.Length; contador++)
        { 
            pessoas[contador] = new Pessoas();
            //---------------------------------------------------------\\

            Console.WriteLine("--------------------------------------------------------");

            //Requisitando nomes
            Console.WriteLine($"\nDigite Nomes {contador + 1}: ");
            pessoas[contador].Nome = Console.ReadLine();

            //---------------------------------------------------------\\


            //Requisitando Idade
            Console.WriteLine("Digite sua idade");
            pessoas[contador].Idade = Convert.ToInt32(Console.ReadLine());
            
            //---------------------------------------------------------\\


            //Requisitando Sexo
            Console.WriteLine("Digite seu sexo M | F: ");
            pessoas[contador].Sexo = Console.ReadLine();

            //---------------------------------------------------------\\


            //Requsitando Endereço
            Console.WriteLine("Digite seu endereço: ");
            pessoas[contador].Endereco = Console.ReadLine();

            //---------------------------------------------------------\\

        }

        foreach (Pessoas buscandoPessoa in pessoas)
        {
            Console.WriteLine("--------------------------------------------------------");

            System.Console.WriteLine("O seu nome é: " + buscandoPessoa.Nome);
            System.Console.WriteLine("A sua idade é : " + buscandoPessoa.Idade);
            System.Console.WriteLine("Seu sexo é : " + buscandoPessoa.Sexo);
            System.Console.WriteLine("Voce mora no endereço: " + buscandoPessoa.Endereco);

        }

        /* 
    
        string testeNome = "Leo";

        bool contem = false;

        Console.WriteLine("----------------------------");


        string[] TesteContem = new string[pessoas.Length];

        for (int i = 0; i < pessoas.Length; i++)
        {
            TesteContem[i] = pessoas[i].Nome;

        }

        Console.WriteLine("----------------------------");
        foreach(string  nome in TesteContem)
        {
            System.Console.WriteLine(nome);
        }
        Console.WriteLine("----------------------------");

        foreach (string procurando in TesteContem)
        {
            if (procurando == testeNome)
            {
                contem = true;
                System.Console.WriteLine(contem);
            }
            
        }
            */
    }
}