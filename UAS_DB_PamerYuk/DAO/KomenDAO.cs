using MySql.Data.MySqlClient;

namespace UAS_DB_PamerYuk.Repository.DAO
{
    public class KomenDAO
    {
        private readonly MySqlConnection connection;

        public KomenDAO(MySqlConnection connection) { this.connection = connection; }
    }
}
