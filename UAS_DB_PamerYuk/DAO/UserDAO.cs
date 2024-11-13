using MySql.Data.MySqlClient;

namespace UAS_DB_PamerYuk.Repository.DAO
{
    public class UserDAO
    {
        private readonly MySqlConnection connection; 

        public UserDAO(MySqlConnection connection) { this.connection = connection; }
    }
}
