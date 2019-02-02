using System;
using System.Collections.Generic;
using Cognizant.Domain.Entities;
using Cognizant.Domain.Interfaces;
using Cognizant.Ado.AdoCon;
using System.Data.SqlClient;
using Cognizant.App.Services;

namespace Cognizant.Ado.Repositories
{
    public class RepositoryConta : IRepositoryConta
    {
        private DbCon contexto = new DbCon();
        private AjustarCampoMonetario ajuste = new AjustarCampoMonetario();
        public void Add(Conta obj)
        {
            var strQuery = "";
            strQuery += String.Format("insert into Conta output inserted.ContaId values (");
            strQuery += String.Format("{0},", obj.ContaId);
            strQuery += String.Format("{0},", ajuste.PontoVirgula(obj.SaldoDebito));
            strQuery += String.Format("{0}", ajuste.PontoVirgula(obj.CreditoDisponivel));
            strQuery += ")";
            contexto.ExecutaComando(strQuery);
        }

        public IEnumerable<Conta> GetAll()
        {
            var strQuery = "";
            strQuery += String.Format("select * from Conta");
            var reader = contexto.ExecutaComandoComRetorno(strQuery);
            var retorno = TransformaReaderEmLista(reader);
            contexto.con.Close();
            return retorno;
        }

        public Conta GetById(int id)
        {
            Conta conta = new Conta();
            var strQuery = "";
            strQuery += String.Format
                ("select * from Conta where ContaId = {0}", id);
            var reader = contexto.ExecutaComandoComRetorno(strQuery);
            if (reader.Read())
            {
                conta = new Conta()
                {
                    ContaId = int.Parse(reader["ContaId"].ToString()),
                    SaldoDebito = decimal.Parse(reader["SaldoDebito"].ToString()),
                    CreditoDisponivel = decimal.Parse(reader["CreditoDisponivel"].ToString())
                };
            }
            contexto.con.Close();
            return conta;
        }

        public void Remove(Conta obj)
        {
            var strQuery = "";
            strQuery += "delete from Conta where ContaId = ";
            strQuery += obj.ContaId.ToString();
            contexto.ExecutaComando(strQuery);
        }

        public void Update(Conta obj)
        {
            
            var strQuery = "";
            strQuery += "update Conta set ";
            strQuery += String.Format("SaldoDebito = {0},", ajuste.PontoVirgula(obj.SaldoDebito));
            strQuery += String.Format("CreditoDisponivel = {0} ", ajuste.PontoVirgula(obj.CreditoDisponivel));
            strQuery += String.Format("where ContaId = {0}", obj.ContaId);
            contexto.ExecutaComando(strQuery);
        }

        public void Inserir(Conta obj)
        {
            
            var strQuery = "";
            strQuery += String.Format("insert into Conta values (");
            strQuery += String.Format("{0},", obj.ContaId);
            strQuery += String.Format("{0},", ajuste.PontoVirgula(obj.SaldoDebito));
            strQuery += String.Format("{0}", ajuste.PontoVirgula(obj.CreditoDisponivel));
            strQuery += ")";
            contexto.ExecutaComando(strQuery);
        }

        List<Conta> TransformaReaderEmLista(SqlDataReader reader)
        {
            List<Conta> lista = new List<Conta>();
            while (reader.Read())
            {
                Conta conta = new Conta() {
                    ContaId = int.Parse(reader["ContaId"].ToString()),
                    SaldoDebito = decimal.Parse(reader["SaldoDebito"].ToString()),
                    CreditoDisponivel = decimal.Parse(reader["CreditoDisponivel"].ToString())
                };
                lista.Add(conta);
            }
            return lista;
            
        }
    }
}
