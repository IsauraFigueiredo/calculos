using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{/// <summary>
/// Implementa operações de conversão.
/// </summary>
    static class Conversoes
    {
        /// <summary>
        /// Tipo de conversão de Temperatura a executar.
        /// </summary>
       public enum ConversaoTemperatura
       {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
       }
        /// <summary>
        /// Conversaode temperaturas
        /// </summary>
        /// <param name="conversao">A conversão a efetua.r</param>
        /// <param name="temperatura">A temperatura a converter.</param>
        /// <returns>Retorna o resuktado da conversão.</returns>
       public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
       {
           if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
           {
               return (temperatura * 1.800 + 32);
           }
           else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
           {
                return ((temperatura - 32) / 1.800);
           }

           return -1;
       }
    }
}
