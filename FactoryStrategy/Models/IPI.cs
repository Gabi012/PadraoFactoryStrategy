
namespace Impostos.Models
{
    public class IPI : IImposto
    {
        public decimal Calcular(decimal valor) => valor * 0.10m;
    }
}
