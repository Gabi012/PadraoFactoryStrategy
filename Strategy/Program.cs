// Interface da estratégia
public interface IImpostoStrategy
{
    decimal Calcular(decimal valor);
}

// Estratégias concretas
public class ICMS : IImpostoStrategy
{
    public decimal Calcular(decimal valor)
    {
        return valor * 0.18m; // 18%
    }
}

public class ISS : IImpostoStrategy
{
    public decimal Calcular(decimal valor)
    {
        return valor * 0.05m; // 5%
    }
}

public class IPI : IImpostoStrategy
{
    public decimal Calcular(decimal valor)
    {
        return valor * 0.15m; // 15%
    }
}

// Contexto que usa a estratégia
public class CalculadoraImposto
{
    private IImpostoStrategy _estrategia;

    public CalculadoraImposto(IImpostoStrategy estrategia)
    {
        _estrategia = estrategia;
    }

    public void DefinirEstrategia(IImpostoStrategy estrategia)
    {
        _estrategia = estrategia;
    }

    public decimal CalcularImposto(decimal valor)
    {
        return _estrategia.Calcular(valor);
    }
}
class Program
{
    static void Main()
    {
        // Uso
        var calculadora = new CalculadoraImposto(new ICMS());
        var imposto = calculadora.CalcularImposto(1000);
        Console.WriteLine($"ICMS: R$ {imposto}");

        // Mudando a estratégia em tempo de execução
        calculadora.DefinirEstrategia(new ISS());
        imposto = calculadora.CalcularImposto(1000);
        Console.WriteLine($"ISS: R$ {imposto}");
    }
}