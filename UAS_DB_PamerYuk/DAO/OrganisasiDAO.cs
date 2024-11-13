using MySql.Data.MySqlClient;

namespace UAS_DB_PamerYuk.Repository.DAO
{
    public class OrganisasiDAO
    {
        private readonly MySqlConnection connection;

        public OrganisasiDAO(MySqlConnection connection) { this.connection = connection; }
    }
}
