using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ex_4;
namespace Ex_4
{
    public class Guitarra
    {
        private static string Afinacao { get; set; }
        
        static Guitarra()
        {
        Afinacao = "SOL"; 
        }
        public static void Tocar()
        {
            TomAfinado();
        }
        public static void Tocar(string afinacaoAtual)
        {
            Afinacao = afinacaoAtual;
            TomAfinado();
        }
        private static void TomAfinado()
        {
        Console.WriteLine($"A guitarra está com afinação em {Afinacao}");
        }
    } 

}