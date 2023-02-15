using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ex_5;

namespace Ex_5
{
    public class Cobrar
    {
        private Decimal Valor {get;}
        private Decimal Multa {get;}
        private Decimal SomaValor {get; set;}
        public Cobrar(Decimal valor, Decimal multa, Decimal somaValor)
        {   
                this.Valor=valor;
                this.Multa=multa;
                this.SomaValor=somaValor; 
        }
        
            private void CalcularMulta()
                {
                    SomaValor = Valor+Multa;
                    Console.WriteLine($"Valor Cobrado {Valor}, Multa {Multa}, Soma Valor {SomaValor}");
                }
           
            public void Calcular()
                {
                    CalcularMulta();
                }       
        
        
    }
} 
