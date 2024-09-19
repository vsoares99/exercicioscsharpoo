using Exercicio14.Entities;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, health));
                }else if (type == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberEmployees));
                }
            }

            double totalTax = 0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine($"{taxPayer.Name}: $ {taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                totalTax += taxPayer.Tax();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {totalTax.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}