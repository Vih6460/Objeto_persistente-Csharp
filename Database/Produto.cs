using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class Produto
    {
        protected SqlConnection sql
            = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BDAula3;Data Source=PC-VIH\\SQLEXPRESS");

        public void Gravar(string nome, string marca, string descricao, double valor)
        {
            string comandosql = "insert into tbproduto(nome, marca, descrição, valor) values('" + nome + "','" + marca + "','" + descricao + "'," + valor + ");";
            SqlCommand sqlCommand;
            try
            {
                sql.Open();
                sqlCommand = new SqlCommand(comandosql, sql);
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sql.Close();
            }
        }
    }
}
