using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_8
{
    public class Pessoa
    {
        public string NomePessoa { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Pessoa(string nomePessoa, DateTime dataDeNascimento)
        {
            NomePessoa=nomePessoa;
            DataDeNascimento=dataDeNascimento;
        }
        public void MostrarIdade()
        {
            int idade = CalcularIdade();
            Console.WriteLine($"Nome {NomePessoa}, tem a idade {idade}");
        } 
        private int CalcularIdade()
        {
                var dataAtual = DateTime.Now;
                var idade = dataAtual.Year - DataDeNascimento.Year;
                if (DataDeNascimento > dataAtual.AddYears(-idade))
                    {
                        idade--;
                    }
                    return idade;

        }
       
    }
}