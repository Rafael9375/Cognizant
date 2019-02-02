
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Cognizant.Ado.AdoCon
{
    public class DbCon
    {
        public SqlConnection con;
        public DbCon()
        {
            con = new SqlConnection("Server=den1.mssql7.gear.host;" + 
                "Database=cognizant;" + 
                "User Id=cognizant;" + 
                "Password=Fw5NG3S!~Xt5;");
        }

        public void ExecutaComando(string strQuery)
        {
            con.Open();
            var cmdComando = new SqlCommand
            {
                CommandText = strQuery,
                CommandType = CommandType.Text,
                Connection = con
            };
            var teste = (int)cmdComando.ExecuteScalar();            
            con.Close();
            
        }

        public SqlDataReader ExecutaComandoComRetorno(string strQuery)
        {
            SqlDataReader reader;
            con.Open();
            var cmdComando = new SqlCommand(strQuery, con);
            return reader = cmdComando.ExecuteReader();
        }
                
    }
}
