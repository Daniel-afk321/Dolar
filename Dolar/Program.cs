using System;
using System.Globalization;

namespace Dolar
{
    class Program
    {
       
       

        static void Main(string[] args)
        {
            // IOF 4,08 = link do site que peguei a informação 
            //https://agenciabrasil.ebc.com.br/economia/noticia/2021-09/comecam-a-valer-hoje-novas-aliquotas-do-IOF
            //Cotação atual R$5,671, https://economia.uol.com.br/cotacoes/cambio/
            //=====================================================Programa==========================================================
            string cont = "S";
            //Caso o usuario coloque SIM ou S, executa as linhas declaradas dentro do while; do contrário, sai do loop
            while (cont == "S" || cont == "SIM")

            {
                // o usuario vai entrar com a cotação do dolar
                Console.WriteLine("Digite a cotação atual do dolar?");
                double cotacao = double.Parse(Console.ReadLine());
                //o usuario vai entrar com um valor para comprar dolares 
                Console.WriteLine("Digite quantos dolares voce ira comprar?");
                double compra = double.Parse(Console.ReadLine());
                double valorCompraComIof = ConversorDeMoeda.ConversaoDolar(cotacao, compra);
                double Reais = ConversorDeMoeda.ValorEmReais(cotacao, compra);

                //Valor que ele ira pagar em Reais 
                Console.WriteLine($"Valor a ser pago em Reais = R${Reais.ToString("C0")}");
                //informa a % paga de IOF pelo usuário
                Console.WriteLine("valor a ser pago de IOF = {0}%", ConversorDeMoeda.Iof );
                //valor total da compra com o IOF incluido
                Console.WriteLine($"Valor total da compra com IOF = R${valorCompraComIof.ToString("C0")}");
                //esta perguntando se o usuario que fazer um novo calculo
                Console.WriteLine("Deseja calcular um novo caso?(Sim/Não)");
                //ToUpper é usado para converter qualquer caracter em letras maiúsculas para nao da poblema no programa
                cont = Console.ReadLine().ToUpper();

            }            

        }
    }
}
