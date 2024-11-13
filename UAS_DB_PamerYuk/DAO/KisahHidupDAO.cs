using MySql.Data.MySqlClient;

namespace UAS_DB_PamerYuk.Repository.DAO
{
    public class KisahHidupDAO
    {
        private readonly MySqlConnection connection;

        public KisahHidupDAO(MySqlConnection connection) { this.connection = connection; }
    }
}
