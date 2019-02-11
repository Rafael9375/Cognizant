using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerosPares
{
    public class Comparavel
    {
        public int valor { get; set; }
        public Comparavel()
        {
            System.Console.WriteLine("Digite o valor do atributo encapsulado: ");
            valor = int.Parse(System.Console.ReadLine());
        }

        public bool MaiorOuIgual()
        {
            var retorno = false;
            System.Console.WriteLine("Digite o parametro para ser comparado (v>=p): ");
            var parametro = int.Parse(System.Console.ReadLine());
            if (valor >= parametro)
            {
                retorno = true;
            }
            return retorno;
        }

        public bool MenorOuIgual()
        {
            var retorno = false;
            System.Console.WriteLine("Digite o parametro para ser comparado (v<=p): ");
            var parametro = int.Parse(System.Console.ReadLine());
            if (valor <= parametro)
            {
                retorno = true;
            }
            return retorno;
        }

        public bool DiferenteDe()
        {
            var retorno = false;
            System.Console.WriteLine("Digite o parametro para ser comparado (v!=p): ");
            var parametro = int.Parse(System.Console.ReadLine());
            if (valor != parametro)
            {
                retorno = true;
            }
            return retorno;
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1000; i > 100; i--)
            //{
            //    if (i % 2 != 0)
            //    {
            //        System.Console.Write(i + ", ");
            //    }
            //}
            //System.Console.ReadKey();

            //int[] lista = new int[100];
            //for (int i = 0; i < lista.Count(); i++)
            //{
            //    System.Console.WriteLine
            //        ("Digite o número da posição {0} da lista: ", i);
            //    lista[i] = int.Parse(System.Console.ReadLine());
            //}
            //System.Console.WriteLine();
            //System.Console.WriteLine("O maior número é: ");
            //System.Console.WriteLine(lista.Max());
            //System.Console.WriteLine();
            //System.Console.WriteLine("O menor número é: ");
            //System.Console.WriteLine(lista.Min());
            //System.Console.ReadKey();

            //string Nome, Menssagem;
            //DateTime DataEntrada, DataNac;
            //int Idade, TempoServico, diferencaMesDia = 0;
            //System.Console.WriteLine
            //    ("Digite seu nome: ");
            //Nome = System.Console.ReadLine();
            //System.Console.WriteLine
            //    ("Digite a data de nascimento (dd/mm/aaaa): ");
            //DataNac = DateTime.ParseExact(
            //    System.Console.ReadLine(),
            //    "dd/MM/yyyy",
            //    CultureInfo.InvariantCulture);
            //System.Console.WriteLine
            //    ("Digite a data de ingresso na empresa (dd/mm/aaaa): ");
            //DataEntrada = DateTime.ParseExact(
            //    System.Console.ReadLine(),
            //    "dd/MM/yyyy",
            //    CultureInfo.InvariantCulture);
            //var diaAtual = int.Parse(DateTime.Now.Day.ToString());
            //var diaEntrada = int.Parse(DataEntrada.Day.ToString());
            //var diaNac = int.Parse(DataNac.Day.ToString());
            //var mesAtual = int.Parse(DateTime.Now.Month.ToString());
            //var mesEntrada = int.Parse(DataEntrada.Month.ToString());
            //var mesNac = int.Parse(DataNac.Month.ToString());
            //if (mesAtual < mesNac)
            //{
            //    diferencaMesDia = 1;
            //}
            //if (mesAtual == mesNac &&
            //        diaAtual < diaNac)
            //{
            //    diferencaMesDia = 1;
            //}
            //Idade = DateTime.Now.Year - DataNac.Year - diferencaMesDia;
            //diferencaMesDia = 0;
            //if (mesAtual < mesEntrada)
            //{
            //    diferencaMesDia = 1;
            //}
            //if (mesAtual == mesEntrada &&
            //        diaAtual < diaEntrada)
            //{
            //    diferencaMesDia = 1;
            //}
            //TempoServico = DateTime.Now.Year - DataEntrada.Year - diferencaMesDia;
            //if (mesAtual < mesEntrada)
            //{
            //    Menssagem = "Apto para aposentadoria";
            //}
            //else
            //{
            //    Menssagem = "Inapto para aposentadoria";
            //}
            //System.Console.WriteLine();
            //System.Console.WriteLine("Nome: {0}", Nome);
            //System.Console.WriteLine("Idade: {0}", Idade);
            //System.Console.WriteLine("Tempo de trabalho: {0} anos", TempoServico);
            //System.Console.WriteLine("Mensagem: {0}", Menssagem);
            //System.Console.ReadKey();

            //int totalMercadorias;
            //System.Console.WriteLine("Digite o total de mercadorias disponíveis no estoque: ");
            //totalMercadorias = int.Parse(System.Console.ReadLine());
            //decimal[] mercadorias = new decimal[totalMercadorias];
            //for (int i = 0; i < mercadorias.Count(); i++)
            //{
            //    System.Console.WriteLine("Digite o preço da mercadoria {0}:", i);
            //    mercadorias[i] = decimal.Parse(System.Console.ReadLine());
            //}
            //var valorTotal = mercadorias.Sum();
            //var media = valorTotal / totalMercadorias;
            //System.Console.WriteLine();
            //System.Console.WriteLine("O valor total em estoque é: {0}", valorTotal);
            //System.Console.WriteLine("A média do valor total é: {0}", string.Format("{0:N}", media));
            //System.Console.ReadKey();

            var comparavel = new Comparavel();
            var retorno = comparavel.MaiorOuIgual();
            System.Console.ReadKey();
        }
    }
}
