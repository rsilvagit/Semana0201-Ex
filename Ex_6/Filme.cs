using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ex_6;
namespace Ex_6
{
    public class Filme
    {
          public string NomeFilme {get; set;}
          public string Categoria {get; set;}

          public void DadosParaImpressao(String nomeDoFilme, String categoria)
          {
            this.NomeFilme=nomeDoFilme;
            this.Categoria=categoria;
          }
          public void ImpressaonaTela()
          {
            Console.WriteLine($"Filme {NomeFilme}");
            Console.WriteLine($"Categoria {Categoria}");

          }
    }
    
}