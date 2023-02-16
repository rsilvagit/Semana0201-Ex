using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_8
{
    public class Pessoa
    {
        public string NomePessoa { get; set; }
        DateTime DataDeNascimento { get; set; }
        public int idade {get; set;}


        public Pessoa(string nomePessoa, DateTime dataDeNascimento)
        {
            this.NomePessoa=nomePessoa;
            this.DataDeNascimento=dataDeNascimento;
        }
        private void CalcularIdade()
        {
            var dataNascimento = new DateTime();
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - dataNascimento.Year;
                if (dataNascimento > dataAtual.AddYears(-idade))
                    {
                        idade--;
                    }


        }
        public void MostrarIdade()
        {
            CalcularIdade();
            Console.WriteLine($"Nome {NomePessoa}, tem a idade {idade}");
        }

    }
}