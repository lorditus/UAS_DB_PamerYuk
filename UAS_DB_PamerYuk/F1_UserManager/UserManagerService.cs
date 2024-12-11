using MySql.Data.MySqlClient;
using UAS_DB_PamerYuk.Repository.DAO;

namespace UAS_DB_PamerYuk.F3_Chat
{
    public class UserManagerService
    {
        private readonly UserDAO userDAO;

        public UserManagerService(MySqlConnection connection)
        {
            userDAO = new UserDAO(connection);
        }
    }
}
