using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;

namespace Cognizant.App.Services
{
    public class ResgataCotacao
    {
        public double Retorno()
        {

            WebClient client = new WebClient();
            var t = client.DownloadString("https://economia.uol.com.br/");
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(t);
            var _real = "";
            string formatado;
            var htmlNodes = doc.DocumentNode
                        .SelectNodes("//a[@class='subtituloGrafico subtituloGraficoValor']") ==
                        null ? doc.DocumentNode.InnerHtml : doc.DocumentNode
                        .SelectSingleNode("//a[@class='subtituloGrafico subtituloGraficoValor']").InnerHtml;
            formatado = htmlNodes.Substring(3);
            
            var cotacao = double.Parse(formatado);
            formatado = string.Format("{0:#.#,##}", formatado);
            //var m2 = string.Format("{0:N}",m);
            //formatado = string.Format("{0:0,0.00}", formatado);
            //decimal real, conversao;
            //cotacao = decimal.Parse(String.Format("{0:0,0.00}", "3,888,88"));

            //_real = System.Console.ReadLine();
            //real = Convert.ToDecimal(_real);
            //conversao = real / cotacao;
            //conversao = decimal.Parse(string.Format("{0:N}", conversao));
            //System.Console.WriteLine("O valor de R${0} convertido para dolar é igual à {1}",
            //    real, conversao);
            //System.Console.ReadKey();
            return cotacao;

        }
    }
}
