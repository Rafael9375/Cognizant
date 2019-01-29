using Cognizant.Domain.Interfaces;
using System;
using System.Collections.Generic;
using Cognizant.Domain.Entities;
using Cognizant.Ado.AdoCon;
using System.Data.SqlClient;

namespace Cognizant.Ado.Repositories
{
    public class RepositoryPessoa : IRepositoryPessoa
    {
        private DbCon contexto = new DbCon();
        public void Add(Pessoa obj)
        {
            if (obj.PessoaId > 0)
                Inserir(obj);
            else
                Update(obj);
        }

        public IEnumerable<Pessoa> GetAll()
        {
            var strQuery = "select * from Pessoa";
            var reader = contexto.ExecutaComandoComRetorno(strQuery);
            return TransformaReaderEmLista(reader);
        }

        public Pessoa GetById(int id)
        {
            Pessoa pessoa = new Pessoa();
            var strQuery = String.Format
                ("select * from Pessoa where PessoaId = {0}", id);
            var reader = contexto.ExecutaComandoComRetorno(strQuery);
            if (reader.Read())
            {
                pessoa = new Pessoa()
                {
                    PessoaId = int.Parse(reader["PessoaId"].ToString()),
                    Nome = reader["Nome"].ToString()
                };
            }
            return pessoa;
        }

        public void Remove(Pessoa obj)
        {
            var strQuery = String.Format
                ("delete from Pessoa where PessoaId = {0}", obj.PessoaId);
        }

        public void Update(Pessoa obj)
        {
            var strQuery = ("update Pessoa set ");
            strQuery += String.Format("Nome = {0} ", obj.Nome);
            strQuery += String.Format("where PessoaId = {0}", obj.PessoaId);
            contexto.ExecutaComando(strQuery);
        }

        List<Pessoa> TransformaReaderEmLista(SqlDataReader reader)
        {
            List<Pessoa> lista = new List<Pessoa>();
            while (reader.Read())
            {
                var aux = new Pessoa()
                {
                    PessoaId = int.Parse(reader["PessoaId"].ToString()),
                    Nome = reader["Nome"].ToString()
                };
                lista.Add(aux);
            }
            return lista;
        }

        public void Inserir(Pessoa pessoa)
        {
            var strQuery = "";
            strQuery += "insert into Pessoa ";
            strQuery += String.Format("values ('{0}')", pessoa.Nome);
            contexto.ExecutaComando(strQuery);
        }
    }
}
