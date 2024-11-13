using MySql.Data.MySqlClient;

namespace UAS_DB_PamerYuk.Repository.DAO
{
    public class KontenDAO
    {
        private readonly MySqlConnection connection;

        public KontenDAO(MySqlConnection connection) { this.connection = connection; }
    }
}
