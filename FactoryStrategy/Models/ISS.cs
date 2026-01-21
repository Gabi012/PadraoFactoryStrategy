
namespace Impostos.Models
{
    public class ISS : IImposto
    {
        public decimal Calcular(decimal valor) => valor * 0.05m;
    }
}
