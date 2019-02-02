using System;
using System.Collections.Generic;
using Cognizant.Domain.Entities;
using Cognizant.Domain.Interfaces;
using Cognizant.Ado.AdoCon;
using System.Data.SqlClient;
using Cognizant.App.Services;

namespace Cognizant.Ado.Repositories
{
    public class RepositoryCompra : IRepositoryCompra
    {
        private DbCon db = new DbCon();
        AjustarCampoMonetario ajustar = new AjustarCampoMonetario();
        public void Add(Compra obj)
        {
            var strQuery = "";
            strQuery += "insert into Compra values (";
            strQuery += String.Format("'{0}', ", obj.dbLoja);
            strQuery += String.Format("{0}, ", obj.dbParcelas);
            strQuery += String.Format("{0}, ", obj.dbParcelasQuitadas);
            strQuery += String.Format("{0}, ", ajustar.PontoVirgula(obj.dbValorParcela));
            strQuery += String.Format("{0}", obj.dbContaId);
            strQuery += ")";
            db.ExecutaComando(strQuery);
        }

        public IEnumerable<Compra> GetAll()
        {
            var strQuery = "";
            strQuery += "select * from Compra";
            var reader = db.ExecutaComandoComRetorno(strQuery);
            var lista = TransformaEmLista(reader);
            db.con.Close();
            return lista;
            
        }

        public Compra GetById(int id)
        {
            var strQuery = "";
            strQuery += "select * from Compra where CompraId = ";
            strQuery += id;
            var reader = db.ExecutaComandoComRetorno(strQuery);
            var compra = new Compra()
            {
                dbCompraId = int.Parse(reader["CompraId"].ToString()),
                dbLoja = reader["Loja"].ToString(),
                dbParcelas = int.Parse(reader["Parcelas"].ToString()),
                dbParcelasQuitadas = int.Parse(reader["ParcelasQuitadas"].ToString()),
                dbValorParcela = decimal.Parse(reader["ValorParcela"].ToString()),
                dbContaId = int.Parse(reader["ContaId"].ToString())
            };
            db.con.Close();
            return compra;
        }

        public void Remove(Compra obj)
        {
            var strQuery = "";
            strQuery += "delete from Compra where CompraId = ";
            strQuery += obj.dbCompraId;
        }

        public void Update(Compra obj)
        {
            var strQuery = "";
            strQuery += "Update Compra set ";
            strQuery += String.Format("Loja = '{0}', ", obj.dbLoja);
            strQuery += String.Format("Parcelas = {0}, ", obj.dbParcelas);
            strQuery += String.Format("ParcelasQuitadas = {0}, ", obj.dbParcelasQuitadas);
            strQuery += String.Format("ValorParcela = {0}, ", ajustar.PontoVirgula(obj.dbValorParcela));
            strQuery += String.Format("ContaId = {0}", obj.dbContaId);
            strQuery += String.Format("where CompraId = ", obj.dbCompraId);
            db.ExecutaComando(strQuery);
        }

        public IEnumerable<Compra> TransformaEmLista(SqlDataReader reader)
        {
            List<Compra> lista = new List<Compra>();
            while (reader.Read())
            {
                Compra compra = new Compra()
                {
                    dbCompraId = int.Parse(reader["CompraId"].ToString()),
                    dbLoja = reader["Observacao"].ToString(),
                    dbValorParcela = decimal.Parse(reader["ValorParcela"].ToString()),
                    dbParcelasPendentes = int.Parse(reader["ParcelasPendentes"].ToString())
                };
                if (compra.dbParcelasPendentes != 0)
                {
                    lista.Add(compra);
                }
            }
            return lista;
        }

        public IEnumerable<Compra> SelecionarCompras(int id)
        {
            var strQuery = "select * from Compras where ";
            strQuery += String.Format("ContaId = {0}", id);
            var reader = db.ExecutaComandoComRetorno(strQuery);
            var retorno = TransformaEmLista(reader);
            db.con.Close();
            return retorno;
        }
    }
}
