using MySql.Data.MySqlClient;
using System.Windows.Documents;

namespace UAS_DB_PamerYuk.Repository.DAO
{
    public class KomenDAO
    {
        private readonly MySqlConnection connection;

        public KomenDAO(MySqlConnection connection) { this.connection = connection; }
    }
}
