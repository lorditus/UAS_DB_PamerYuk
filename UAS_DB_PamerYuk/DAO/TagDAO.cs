using MySql.Data.MySqlClient;

namespace UAS_DB_PamerYuk.Repository.DAO
{
    public class TagDAO
    {
        private readonly MySqlConnection connection;

        public TagDAO(MySqlConnection connection) { this.connection = connection; }
    }
}
