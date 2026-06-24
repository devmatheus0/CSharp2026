using System;
using System.Collections.Generic;
using System.Globalization;
using ImpostoContribuinte.Entidades;

namespace ImpostoContribuinte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de contribuintes: ");
            int n = int.Parse(Console.ReadLine()!);

            List<Contribuinte> contribuintes = new List<Contribuinte>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\n--- Contribuinte {i} ---");
                Console.Write("Tipo (1 - Pessoa Fisica / 2 - Pessoa Juridica): ");
                int tipo = int.Parse(Console.ReadLine()!);

                Console.Write("Nome: ");
                string nome = Console.ReadLine()!;

                Console.Write("Renda anual: ");
                double renda = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

                if (tipo == 1)
                {
                    Console.Write("Gastos com saude: ");
                    double saude = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                    contribuintes.Add(new PessoaFisica(nome, renda, saude));
                }
                else
                {
                    Console.Write("Numero de funcionarios: ");
                    int func = int.Parse(Console.ReadLine()!);
                    contribuintes.Add(new PessoaJuridica(nome, renda, func));
                }
            }

            Console.WriteLine("\n========== RELATORIO DE IMPOSTOS ==========");

            double totalImposto = 0.0;

            foreach (Contribuinte c in contribuintes)
            {
                double imposto = c.CalcularImposto();
                totalImposto += imposto;

                string tipo = c is PessoaFisica ? "Pessoa Fisica" : "Pessoa Juridica";
                Console.WriteLine($"\nNome: {c.Nome} ({tipo})");
                Console.WriteLine($"Renda anual: R$ {c.RendaAnual:F2}");
                Console.WriteLine($"Imposto a pagar: R$ {imposto:F2}");
            }

            Console.WriteLine("\n============================================");
            Console.WriteLine($"Total de imposto arrecadado: R$ {totalImposto:F2}");

            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
