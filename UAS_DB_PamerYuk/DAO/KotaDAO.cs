using MySql.Data.MySqlClient;

namespace UAS_DB_PamerYuk.Repository.DAO
{
    public class KotaDAO
    {
        private readonly MySqlConnection connection;

        public KotaDAO(MySqlConnection connection) { this.connection = connection; }
    }
}
