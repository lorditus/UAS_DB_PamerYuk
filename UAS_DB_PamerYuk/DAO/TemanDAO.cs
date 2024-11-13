using MySql.Data.MySqlClient;

namespace UAS_DB_PamerYuk.Repository.DAO
{
    public class TemanDAO
    {
        private readonly MySqlConnection connection;

        public TemanDAO(MySqlConnection connection) { this.connection = connection; }
    }
}
