using MySql.Data.MySqlClient;
using UAS_DB_PamerYuk.Repository.DAO;

namespace UAS_DB_PamerYuk.F4_Content
{
    public class FriendshipService
    {
        private readonly UserDAO userDAO;
        private readonly TemanDAO temanDAO;
        private readonly OrganisasiDAO organisasiDAO;

        public FriendshipService(MySqlConnection connection)
        {
            userDAO = new UserDAO(connection);
            temanDAO = new TemanDAO(connection);
            organisasiDAO = new OrganisasiDAO(connection);
        }
    }
}
