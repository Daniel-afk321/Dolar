using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolar
{
    class ConversorDeMoeda
    {
        //Static pode ser aplicado a variáveis ​​e métodos, tornando-os métodos / variáveis ​
        public static double Iof = 2.95;
        public static double reais;

        //função que retorna a Conversão Do Dolar
        public static double ConversaoDolar(double cotacao, double valorCompra)
        {

            double total = valorCompra + (valorCompra * (Iof / 100.0));
            return total *= cotacao;
  
        }
        //Função que retorna o valor em reais sem a % do IOF
        public static double  ValorEmReais(double cotacao, double valorCompra)
        {

            reais = cotacao * valorCompra;
            return reais;
            
        }

    }
}
