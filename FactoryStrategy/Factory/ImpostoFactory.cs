
using System;
using Impostos.Models;

namespace Impostos.Factory
{
    public static class ImpostoFactory
    {
        public static IImposto Criar(string tipo)
        {
            return tipo.ToUpper() switch
            {
                "ICMS" => new ICMS(),
                "ISS"  => new ISS(),
                "IPI"  => new IPI(),
                _ => throw new ArgumentException("Imposto inválido")
            };
        }
    }
}
