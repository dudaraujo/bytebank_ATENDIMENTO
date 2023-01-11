using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Net.Http.Headers;
using System.Runtime.Serialization;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

//testaArrayInt();
//testaBusca();

void testaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do array {idades.Length}");

    int soma = 0;

    for (int posicao = 0; posicao < idades.Length; posicao++)
    {
        int idade = idades[posicao];
        Console.WriteLine($"índice [{posicao}] = {idade}");
        soma += idade;
    }

    float media = soma / idades.Length;
    Console.WriteLine($"A soma das idades é {soma}, e a média é {media}");
}

void testaBusca()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.WriteLine($"Digite a {i + 1} palavra");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write($"Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {palavra}");
            break;

        }
    }
}


    Array amostra = Array.CreateInstance(typeof(double), 5);
    amostra.SetValue(5.9, 0);
    amostra.SetValue(1.8, 1);
    amostra.SetValue(7.1, 2);
    amostra.SetValue(10, 3);
    amostra.SetValue(6.9, 4);

    //TestaMediana(amostra);

    void TestaMediana(Array array)
    {
        

        //Clonando o array passado por parâmetro para o método e coventendo eele para double pois o método
        //.Clone retirna um Objeto
        double[] numerosOrdenados = (double[])array.Clone();

        //Colocando em ordem crescente o array
        Array.Sort(numerosOrdenados);

        int tamanho = numerosOrdenados.Length;
        int meio = tamanho / 2;
        double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

    Console.WriteLine($"A mediana da amostra é {mediana}");

    }


//CalculaMedia();

void CalculaMedia()
{
    int[] vetor = new int[2];
    vetor.SetValue(10, 0);
    vetor.SetValue(5, 1);

    int soma2 = 0; 

    for(int i = 0; i < vetor.Length; i++)
    {
        //int numero = vetor[i];
        soma2 = soma2 + vetor[i];
    }

    int media2 = soma2 / vetor.Length;
    Console.WriteLine($"a MEDIA É {media2}");


}

TestaArrayDeContasCorrentes();

//void TestaArrayDeContasCorrentes()
//{
//    ContaCorrente[] listaDeContas = new ContaCorrente[]
//    {
//        new ContaCorrente(874, "7543587-A"),
//        new ContaCorrente(875, "7543587-b"),
//        new ContaCorrente(876, "7543587-c"),
//    };

//    for (int i = 0; i < listaDeContas.Length; i++)
//    {
//        ContaCorrente contaAtual = listaDeContas[i];
//        Console.WriteLine($"índice {i} - Conta: {contaAtual.Conta}");
//    }
//}

void TestaArrayDeContasCorrentes()
{
    ListaContasCorrentes listaDeContas = new ListaContasCorrentes();
    {
        listaDeContas.Adiciona(new ContaCorrente(874, "7543587-A"));
        listaDeContas.Adiciona(new ContaCorrente(874, "7543587-B"));
        listaDeContas.Adiciona(new ContaCorrente(874, "7543587-C"));
        listaDeContas.Adiciona(new ContaCorrente(874, "7543587-A"));
        listaDeContas.Adiciona(new ContaCorrente(874, "7543587-B"));
        listaDeContas.Adiciona(new ContaCorrente(874, "7543587-C"));
        listaDeContas.Adiciona(new ContaCorrente(874, "7543587-A"));
        listaDeContas.Adiciona(new ContaCorrente(874, "7543587-B"));
        listaDeContas.Adiciona(new ContaCorrente(874, "7543587-C"));
        listaDeContas.Adiciona(new ContaCorrente(874, "7543587-A"));
        listaDeContas.Adiciona(new ContaCorrente(874, "7543587-B"));
        listaDeContas.Adiciona(new ContaCorrente(874, "7543587-C"));

        var contaDoAndre = new ContaCorrente(123, "123123123");
        listaDeContas.Adiciona(contaDoAndre);
        listaDeContas.ExibirLista();
        Console.WriteLine("-------------------------------");
        listaDeContas.Remover(contaDoAndre);
        listaDeContas.ExibirLista();
    }

   
}
