
namespace Impostos.Models
{
    public class ICMS : IImposto
    {
        public decimal Calcular(decimal valor) => valor * 0.18m;
    }
}
