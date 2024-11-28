using MySql.Data.MySqlClient;
using UAS_DB_PamerYuk.Repository.DAO;

namespace UAS_DB_PamerYuk.F1_UserManager
{
    public class ChatService
    {
        private readonly UserDAO userDAO;
        private readonly TemanDAO temanDAO;
        private readonly PercakapanDAO percakapanDAO;

        public ChatService(MySqlConnection connection)
        {
            userDAO = new UserDAO(connection);
            temanDAO = new TemanDAO(connection);
            percakapanDAO = new PercakapanDAO(connection);
        }
    }
}
