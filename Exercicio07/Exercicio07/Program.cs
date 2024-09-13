using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio07;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários vão ser registrados? ");
            int registros = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= registros; i++)
            {
                Console.WriteLine($"Funcionário #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                lista.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Entre a id do funcionário que irá receber aumento no salário: ");
            int procurarId = int.Parse(Console.ReadLine());

            Funcionario func = lista.Find(x => x.Id == procurarId);
            
            if (func != null)
            {
                Console.Write("Entre a porcetagem de aumento: ");
                double porcentagem = double.Parse(Console.ReadLine());
                func.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários:");
            foreach (Funcionario obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}