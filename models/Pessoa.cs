using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace function1.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public int Idade { get; set; }

        public Pessoa() { }

        public Pessoa(string nome, string cidade, int idade)
        {
            Nome = nome;
            Cidade = cidade;
            Idade = idade;
        }

        public override string ToString()
        {
            return Nome == null || Cidade == null || Idade == 0
                ? null
                : base.ToString() + " : "
                + " Nome: " + Nome
                + " Cidade: " + Cidade
                + " Idade: " + Idade ;
        }

    }
}