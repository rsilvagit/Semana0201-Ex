using Ex_8;


namespace Ex_8;
static class Program
{
    static void Main()
    {
        var dataNascimento = new DateTime(15, 9, 1984);
        Pessoa pessoa = new Pessoa ("Carlos",dataNascimento);
        pessoa.MostrarIdade();
    }
}

