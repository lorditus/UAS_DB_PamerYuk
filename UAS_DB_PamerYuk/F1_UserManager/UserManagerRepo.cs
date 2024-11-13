using MySql.Data.MySqlClient;
using UAS_DB_PamerYuk.Repository.DAO;

namespace UAS_DB_PamerYuk.F1_UserManager
{
    public class UserManagerRepo
    {
        private readonly UserDAO userDAO;
        private readonly KisahHidupDAO kisahHidupDAO;
        private readonly OrganisasiDAO organisasiDAO;
        private readonly KotaDAO kotaDAO;

        public UserManagerRepo(MySqlConnection connection)
        {
            userDAO = new UserDAO(connection);
            kisahHidupDAO = new KisahHidupDAO(connection);
            organisasiDAO = new OrganisasiDAO(connection);
            kotaDAO = new KotaDAO(connection);
        }
    }
}
