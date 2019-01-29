

using Cognizant.Domain.Entities;
using System;

namespace Cognizant.App.Services
{
    public class AjustarCampoMonetario
    {
        
        //public Conta PontoVirgula(Conta conta)
        //{
        //    conta.SaldoDebito = 
        //        Rotina(conta.SaldoDebito.ToString());
        //    conta.CreditoDisponivel = 
        //        Rotina(conta.CreditoDisponivel.ToString());
        //    return conta;
        //}

        public string PontoVirgula(decimal valorAtual)
        {
            string valorAjustado;
            valorAjustado = valorAtual.ToString().Replace(',', '.');
            return valorAjustado;
        }

        public string TxtBox(string txtbox)
        {
            var txt = txtbox;
            var padrao = "0,00";
            if (txt == padrao)
            {
                txt = "";
            }


            if (txt.Length <= 4)
            {
                txt = txt.Replace("0,", ",");
                if (txt != "")
                {
                    if (txt.Substring(1) == ",")
                    {
                        txt = txt.Replace(",0", "");
                    }
                }
                txt = txt.Replace(",", "");
                txt = padrao.Substring(0, 4 - txt.Length - 1) + txt;
                txtbox = txt;

            }

            if (txt.Length >= 3)
            {
                if (txt.Length == 3
                    && txt.Substring(0, 1) == "0"
                    && txt.Substring(1, 1) != ",")
                {
                    txt = txt.Substring(1);
                }
                txt = txt.Replace(",", "");
                txt = txt.Insert(txt.Length - 1, ",");
                txtbox = txt;
            }
            return txtbox;
        }

        public string TextBoxUp(string txtbox)
        {
            var txt = txtbox;
            var padrao = "0,00";
            if (txt.Length < 4)
            {
                txt = padrao.Substring(0, 4 - txt.Length) + txt;
            }
            else
            {
                txt.Replace(",", "");
                txt = txt.Insert(txt.Length - 3, ",");
            }
            txtbox = txt;
            return txtbox;
        }
    }
}
