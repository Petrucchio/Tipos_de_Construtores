using Tipos_de_Construtores.Models;
class Program
{
    public delegate void Operacao(int x, int y);

    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("Victor","Farias");
        p1.Apresentar();

        Log log = Log.GetInstance();
        log.PropriedadeLog = "Teste instancia";

        Log log2 = Log.GetInstance();
        System.Console.WriteLine(log2.PropriedadeLog);

        Aluno a1 = new Aluno("Henrique", "Batista", "Teste");
        a1.Apresentar();

        Data data = new Data();

        data.Mes = 12;
        System.Console.WriteLine(data.Mes);

    }
}