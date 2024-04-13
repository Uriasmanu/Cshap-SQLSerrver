using System.Data.SqlClient;

namespace ScreenSound.Banco
{
    public class Conexao
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Usuario\\OneDrive\\Documentos\\Urias.mdf;Integrated Security=True;Connect Timeout=30";

        public SqlConnection ObterConexao()
        {
            return new SqlConnection(connectionString);
        }
    }
}
