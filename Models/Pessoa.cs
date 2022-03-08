
namespace Tipos_de_Construtores.Models
{
    public class Pessoa
    {
        private readonly string nome ;
        private readonly string sobrenome;

        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }

        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            Console.WriteLine("Construtor classe pessoa!");
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
        }
    }
}
