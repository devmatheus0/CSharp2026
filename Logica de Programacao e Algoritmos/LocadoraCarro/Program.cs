using System;
using System.Globalization;
using LocadoraCarro.Entidades;
using LocadoraCarro.Servicos;

namespace LocadoraCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a data do aluguel");

            Console.Write("Modelo do carro: ");
            string modelo = Console.ReadLine();

            Console.Write("Retirada (dd/MM/yyyy hh:mm): ");
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Devolucao (dd/MM/yyyy hh:mm): ");
            DateTime fim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Entre com o preco por hora: ");
            double precoPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com o preco por dia: ");
            double precoPorDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Veiculo veiculo = new Veiculo(modelo);
            AluguelCarro aluguel = new AluguelCarro(inicio, fim, veiculo);

            ServAluguel servico = new ServAluguel(precoPorHora, precoPorDia);
            servico.CalcularFatura(aluguel);

            Console.WriteLine();
            Console.WriteLine(aluguel.Fatura.ToString());
        }
    }
}
