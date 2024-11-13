using MySql.Data.MySqlClient;

namespace UAS_DB_PamerYuk.Repository.DAO
{
    public class PercakapanDAO
    {
        private readonly MySqlConnection connection;

        public PercakapanDAO(MySqlConnection connection) { this.connection = connection; }
    }
}
