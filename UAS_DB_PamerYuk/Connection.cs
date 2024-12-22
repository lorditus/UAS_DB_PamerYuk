using MySql.Data.MySqlClient;
using System.Configuration;

namespace UAS_DB_PamerYuk
{
    public class Connection
    {
        private MySqlConnection dbConnection;

        public MySqlConnection DbConnection { get => dbConnection; private set => dbConnection = value; }

        public Connection()
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionGroup userSettings = myConf.SectionGroups["userSettings"];

            var settingsSection = userSettings.Sections["UAS_DB_PamerYuk.Properties.DB"] as ClientSettingsSection;

            string pS = settingsSection.Settings.Get("DbServer").Value.ValueXml.InnerText;
            string pD = settingsSection.Settings.Get("DbName").Value.ValueXml.InnerText;
            string pU = settingsSection.Settings.Get("DbUsername").Value.ValueXml.InnerText;
            // string pP = settingsSection.Settings.Get("DbPassword").Value.ValueXml.InnerText; // Kalau mau run, pakai yang bawah. 
            string pP = "";

            string conString = "Server=" + pS + ";Database=" + pD + ";Uid=" + pU + ";Pwd=" + pP + ";";
            DbConnection = new MySqlConnection(conString);

            GetConnection();
        }

        public void GetConnection()
        {
            if (DbConnection.State == System.Data.ConnectionState.Open) DbConnection.Close();
            DbConnection.Open();
        }

        public static MySqlDataReader JalankanSelect(string command)
        {
            Connection k = new Connection();
            MySqlCommand cmd = new MySqlCommand(command, k.dbConnection);
            MySqlDataReader hasil = cmd.ExecuteReader();
            return hasil;
        }
    }
}
