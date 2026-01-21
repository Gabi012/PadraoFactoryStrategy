// Interface do produto
public interface IVeiculo
{
    void Dirigir();
}

// Implementações concretas
public class Carro : IVeiculo
{
    public void Dirigir()
    {
        Console.WriteLine("Dirigindo um carro...");
    }
}

public class Moto : IVeiculo
{
    public void Dirigir()
    {
        Console.WriteLine("Pilotando uma moto...");
    }
}

public class Caminhao : IVeiculo
{
    public void Dirigir()
    {
        Console.WriteLine("Conduzindo um caminhão...");
    }
}

// Factory (Fábrica)
public abstract class VeiculoFactory
{
    public abstract IVeiculo CriarVeiculo();

    // Método que usa o produto criado
    public void Entregar()
    {
        var veiculo = CriarVeiculo();
        veiculo.Dirigir();
        Console.WriteLine("Veículo entregue!");
    }
}

// Fábricas concretas
public class CarroFactory : VeiculoFactory
{
    public override IVeiculo CriarVeiculo()
    {
        return new Carro();
    }
}

public class MotoFactory : VeiculoFactory
{
    public override IVeiculo CriarVeiculo()
    {
        return new Moto();
    }
}

// Uso
class Program
{
    static void Main()
    {
        VeiculoFactory factory;

        // Criando um carro
        factory = new CarroFactory();
        factory.Entregar();

        // Criando uma moto
        factory = new MotoFactory();
        factory.Entregar();


     // Simple Factory (não é um padrão GoF, mas é comum)


    // Uso do Simple Factory
    var simpleFactory = new SimpleVeiculoFactory();
    var veiculo = simpleFactory.CriarVeiculo("carro");
    veiculo.Dirigir();
    }

    public class SimpleVeiculoFactory
    {
        public IVeiculo CriarVeiculo(string tipo)
        {
            return tipo.ToLower() switch
            {
                "carro" => new Carro(),
                "moto" => new Moto(),
                "caminhao" => new Caminhao(),
                _ => throw new ArgumentException("Tipo de veículo inválido")
            };
        }
    }
}