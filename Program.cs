using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
           string nome;
           string sobrenome;
           string nomeCompleto;
           string nomeCatalogo;
                      
           Console.Write("Digite seu primeiro nome: ");
           nome = Console.ReadLine();
           Console.Write("Digite seu sobrenome: ");
           sobrenome = Console.ReadLine();
           nomeCompleto = $"{nome} {sobrenome}";
           nomeCatalogo = $"{sobrenome.ToUpper()}, {nome}";
           Console.WriteLine($"Nome completo: {nomeCompleto}");
           Console.WriteLine($"Nome catalogo: {nomeCatalogo}");
           
        }
    }
}
