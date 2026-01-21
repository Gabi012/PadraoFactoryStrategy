using System;
using Impostos.Factory;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== CÁLCULO DE IMPOSTOS ===");
            Console.WriteLine("1 - ICMS");
            Console.WriteLine("2 - ISS");
            Console.WriteLine("3 - IPI");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            if (opcao == "0")
                break;

            string tipoImposto = opcao switch
            {
                "1" => "ICMS",
                "2" => "ISS",
                "3" => "IPI",
                _ => null
            };

            if (tipoImposto == null)
            {
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
                continue;
            }

            Console.Write("Digite o valor base: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal valor) || valor <= 0)
            {
                Console.WriteLine("Valor inválido!");
                Console.ReadKey();
                continue;
            }

            var imposto = ImpostoFactory.Criar(tipoImposto);
            var resultado = imposto.Calcular(valor);

            Console.WriteLine();
            Console.WriteLine($"Imposto ({tipoImposto}) calculado: {resultado:C}");
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        Console.WriteLine("Programa encerrado.");
    }
}
