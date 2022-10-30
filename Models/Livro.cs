using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teste
{
    public class Livro
    {
        public Livro(string nome, string autor, string genero, string ano, string editora)
        {
            this.Nome = nome;
            this.Autor = autor;
            this.Genero = genero;
            this.Ano = ano;
            this.Editora = editora;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string Ano { get; set; }
        public string Editora { get; set; }

        public override string ToString()
        {
            string retorno = " ";
            retorno += "Nome do Livro: " + this.Nome + " | ";
            retorno += "Autor: " + this.Autor + " | ";
            retorno += "Genero: " + this.Genero + " | ";
            retorno += "Ano: " + this.Ano + " | ";
            retorno += "Editora: " + this.Editora;
            return retorno;
        }

               
    }

    
}