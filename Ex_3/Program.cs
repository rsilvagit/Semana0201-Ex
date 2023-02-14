using Ex_3;
public class Program
{
   public static void Main (string[] args)
    {
        MensagemCelular mensagem = new MensagemCelular();
        mensagem.Telefone = 22234567;
        mensagem.Mensagem = "Funcionou";
        mensagem.Executar();
    }
}
