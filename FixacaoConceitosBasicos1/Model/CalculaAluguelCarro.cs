using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    public static class CalculaAluguelCarro
    {
        public static double Calcular(int dias, int quilometragemInicial, int quilometragemFinal)
        {
            const double precoPorDia = 100.0; // Exemplo de valor fixo por dia
            const double precoPorKm = 0.75; // Exemplo de valor fixo por km rodado
            
            int kmRodados = quilometragemFinal - quilometragemInicial;
            return (dias * precoPorDia) + (kmRodados * precoPorKm);
        }
    }
}
