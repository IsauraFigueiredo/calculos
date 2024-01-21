using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{/// <summary>
 /// Implementa operações aritméticas.
 /// </summary>

    class Aritmetica
    {/// <summary>
    /// Tipo de conversão de Temperatura a executar.
    /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }
       /// <summary>
       /// Operação Soma
       /// </summary>
       /// <returns>Retorna a soma de dois números.</returns>
        public int Somar(int x, int y)
        {
           return x + y;
        }
       /// <summary>
       /// Operação Subtração
       /// </summary>
       /// <returns>Retorna o resultado da subtração de dois numeros.</returns>
        public int Subtrair(int x, int y)
        {
            return x - y;
        }

        public double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.800 + 32);
            } 
            else if(conversao==ConversaoTemperatura.FahrenheitCelsius )
            {
                return ((temperatura-32 )/1.800);
            }
           
            return -1;  
        }
    }
}
