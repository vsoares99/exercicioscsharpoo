using System.Globalization;

namespace Exercicio07
{
    internal class Funcionario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public double AumentarSalario(double porcentagem)
        {
            return Salario += Salario * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return $"{Id}, {Nome}, {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
