using MySql.Data.MySqlClient;
using UAS_DB_PamerYuk.Repository.DAO;

namespace UAS_DB_PamerYuk.F4_Content
{
    public class ContentRepo
    {
        private readonly UserDAO userDAO;
        private readonly TemanDAO temanDAO;
        private readonly KontenDAO kontenDAO;
        private readonly KomenDAO komenDAO;
        private readonly TagDAO tagDAO;

        public ContentRepo(MySqlConnection connection)
        {
            userDAO = new UserDAO(connection);
            kontenDAO = new KontenDAO(connection);
            komenDAO = new KomenDAO(connection);
            tagDAO = new TagDAO(connection);
        }
    }
}
