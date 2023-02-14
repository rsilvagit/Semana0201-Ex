using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ex_3;

    namespace Ex_3
    {
         public class MensagemCelular
        {
            public int Telefone {get; set;}
            public string Mensagem {get; set;}

        public void Executar()
        {
            EnviarMensagemAoTelefone();
            Console.WriteLine("Metodo Executado pelo Console");
        }
        private void EnviarMensagemAoTelefone()
        {
            Console.WriteLine("Método privado executado na classe");
            Console.WriteLine($"Telefone {Telefone}, Mensagem {Mensagem}");

        }
        }
    }



        


