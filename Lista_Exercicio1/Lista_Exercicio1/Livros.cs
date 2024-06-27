using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lista_Exercicio1
{
    public class Livros
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }

        public Livros(string titulo, string autor, int ano) 
        {
            Titulo = titulo;    
            Autor = autor;
            Ano = ano;
        }

        public override string ToString()
        {
            return Titulo
                + ", "
                + Autor
                + ", "
                + Ano.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
