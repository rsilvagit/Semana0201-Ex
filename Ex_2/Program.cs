// See https://aka.ms/new-console-template for more information
using Ex_2;
public class Program
{
   public static void Main (string[] args)
    {
        DateTime nascimento = new DateTime(1990, 10, 30);
        FichaInscricao fichaInscricao = new FichaInscricao (1,"Manoel",nascimento,true);
        fichaInscricao.imprimirDados();
    }
}
