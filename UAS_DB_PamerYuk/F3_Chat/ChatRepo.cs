using MySql.Data.MySqlClient;
using UAS_DB_PamerYuk.Repository.DAO;

namespace UAS_DB_PamerYuk.F3_Chat
{

    public class ChatRepo
    {
        private readonly UserDAO userDAO;
        private readonly TemanDAO temanDAO;
        private readonly PercakapanDAO percakapanDAO;

        public ChatRepo(MySqlConnection connection) 
        {
            userDAO = new UserDAO(connection);
            temanDAO = new TemanDAO(connection);
            percakapanDAO = new PercakapanDAO(connection);
        }
    }
}
