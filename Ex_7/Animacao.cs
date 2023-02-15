using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_7
{
    public static class Animacao
    {
        public static string Animacao1 {get; set;}
        public static string Animacao2 {get; set;}
        public static string Animacao3 {get; set;}
       
    static Animacao ()
        {
            Animacao1= "Frozen";
            Animacao2= "Ratatoullie";
            Animacao3= "Toy Story";


        }

        public static void Tipo(string animacao1)
        {
            Console.WriteLine($"Animação {animacao1}.");

        }
        public static void Tipo(string animacao2,string animacao3)
        {
            Console.WriteLine($"Animação {animacao2}.");
            Console.WriteLine($"Animação {animacao3}.");

        }
    }
}
