using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_2
{
    
    public class FichaInscricao
    {
        public int id {get;set;}
        public string nome {get;set;}
        public DateTime dataDeNascimento {get; set;}
        public bool menorDeIdade {get; set;}

        public FichaInscricao(int Id, string Nome, DateTime DataDeNascimento, bool MenorDeIdade)
        {
            this.id = Id;
            this.nome = Nome;
            this.dataDeNascimento = DataDeNascimento;
            this.menorDeIdade = MenorDeIdade;


        }
       
        public void imprimirDados()
        {
            if (menorDeIdade==true)
            {
                Console.WriteLine($"Id {id}\r\nNome {nome}\r\nData de Nascimento {dataDeNascimento}\r\nAluno Maior de Idade");
            }
                else
                {
                    Console.WriteLine($"Id {id}\r\nNome {nome}\r\nData de Nascimento {dataDeNascimento}\r\nAluno Menor de Idade");

                }
        }

    }
}