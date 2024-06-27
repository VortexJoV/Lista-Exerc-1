using Lista_Exercicio1;
using System;

List<Livros> livros = new List<Livros>();

Console.WriteLine("Quantos livros irão ser inseridos?");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Clear();
    Console.Write("Qual o titulo do livro: ");
    string titulo = Console.ReadLine();

    Console.Write("Qual o autor do livro: ");
    string autor = Console.ReadLine();

    Console.Write("Qual o ano do livro: ");
    int ano = Convert.ToInt32(Console.ReadLine());

    livros.Add(new Livros(titulo, autor, ano));
    Console.WriteLine();
}

Console.Clear();
Console.Write("Digite o nome do Livro que deseja buscar: ");
string tituloProcurado = Console.ReadLine();

Livros livroEncontrado = livros.Find(livros => livros.Titulo == tituloProcurado);

if (livroEncontrado != null)
{
    Console.Clear();
    Console.WriteLine("Livro encontrado \n\n" + "Titulo: " + livroEncontrado.Titulo);
    Console.WriteLine("Autor: " + livroEncontrado.Autor);
    Console.WriteLine("Ano de lançamento: " + livroEncontrado.Ano);

}
else
{
    Console.Clear();
    Console.WriteLine("Livro não encontrado.");
}