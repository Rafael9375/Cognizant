using Cognizant.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognizant.Domain.Entities;
using Cognizant.Ado.AdoCon;
using Cognizant.App.Services;
using System.Data.SqlClient;

namespace Cognizant.Ado.Repositories
{
    public class RepositoryTransacao : IRepositoryTransacao
    {
        private DbCon db = new DbCon();
        private AjustarCampoMonetario ajustar = new AjustarCampoMonetario();
        public void Add(Transacao obj)
        {
            
            var strQuery = "";
            strQuery = "insert into Transacao values (";
            strQuery += String.Format("'{0}', ", obj.Tipo);
            strQuery += String.Format("'{0}', ", obj.Funcao);
            strQuery += String.Format("{0}, ", ajustar.PontoVirgula(obj.Valor));
            strQuery += String.Format("'{0}', ", obj.Observacao);
            strQuery += String.Format("'{0}', ", obj.Agendamento.ToString("yyyy/MM/dd"));
            strQuery += String.Format("{0}, ", obj.ContaId);
            if (obj.ContaIdTransferencia == 0)
            {
                strQuery += "null";
            }
            else
            {
                strQuery += String.Format("{0}", obj.ContaIdTransferencia);
            }
            
            strQuery += ")";
            db.ExecutaComando(strQuery);
        }

        public IEnumerable<Transacao> GetAll()
        {
            var strQuery = "";
            strQuery += "select * from Transacao";
            var reader = db.ExecutaComandoComRetorno(strQuery);
            var retorno = TransaformaReaderEmLista(reader);
            db.con.Close();
            return retorno;
        }

        public Transacao GetById(int id)
        {
            var strQuery = "";
            strQuery += "select * from Transacao where id = ";
            strQuery += id;
            var reader = db.ExecutaComandoComRetorno(strQuery);
            return new Transacao() {
                TransacaoId = int.Parse(reader["TransacaoId"].ToString()),
                Tipo = reader["Tipo"].ToString(),
                Funcao = reader["Funcao"].ToString(),
                Valor = decimal.Parse(reader["Valor"].ToString()),
                Observacao = reader["Obsevacao"].ToString(),
                ContaId = int.Parse(reader["ContaId"].ToString()),
                ContaIdTransferencia = int.Parse(reader["ContaIdTransferencia"].ToString())
            };
        }

        public void Remove(Transacao obj)
        {
            var strQuery = "";
            strQuery += "delete from Transacao where TransacaoId = ";
            strQuery += obj.TransacaoId.ToString();
            db.ExecutaComando(strQuery);
        }

        public void Update(Transacao obj)
        {
            var strQuery = "";
            strQuery = "update from Transacao set ";
            strQuery += String.Format("Tipo = '{0}', ", obj.Tipo);
            strQuery += String.Format("Funcao = '{0}', ", obj.Funcao);
            strQuery += String.Format("Valor = {0}, ", ajustar.PontoVirgula(obj.Valor));
            strQuery += String.Format("Observacao = '{0}', ", obj.Observacao);
            strQuery += String.Format("Agendamento = '{0}', ", obj.Agendamento);
            strQuery += String.Format("ContaId = {0},", obj.ContaId);
            strQuery += String.Format("ContaIdTransferencia = {0} ", obj.ContaIdTransferencia);
            strQuery += "where TransacaoId = " + obj.TransacaoId.ToString();
            db.ExecutaComando(strQuery);
        }

        public List<Transacao> TransaformaReaderEmLista(SqlDataReader reader)
        {
            List<Transacao> lista = new List<Transacao>();
            while (reader.Read())
            {
                var tr = new Transacao()
                {
                    TransacaoId = int.Parse(reader["TransacaoId"].ToString()),
                    Tipo = reader["Tipo"].ToString(),
                    Funcao = reader["Funcao"].ToString(),
                    Valor = decimal.Parse(reader["Valor"].ToString()),
                    Observacao = reader["Observacao"].ToString(),
                    Agendamento = DateTime.Parse(reader["Agendamento"].ToString()),
                    ContaId = int.Parse(reader["ContaId"].ToString()),
                    ContaIdTransferencia = int.Parse(reader["ContaIdTransferencia"].ToString())
                };
                lista.Add(tr);
            }
            return lista;
        }

        public IEnumerable<Transacao> SelecionarCompras(int id)
        {
            var strQuery = "select * from Compras where ";
            strQuery += String.Format("ContaId = {0}", id);
            var reader = db.ExecutaComandoComRetorno(strQuery);
            var retorno = TransaformaReaderEmLista(reader);
            db.con.Close();
            return retorno;
        }
    }
}
