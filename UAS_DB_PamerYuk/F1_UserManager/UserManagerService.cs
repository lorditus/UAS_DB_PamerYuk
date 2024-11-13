using UAS_DB_PamerYuk.F1_UserManager;

namespace UAS_DB_PamerYuk.F3_Chat
{
    public class UserManagerService
    {
        public readonly UserManagerRepo repo;

        public UserManagerService(UserManagerRepo repo) { this.repo = repo; }
    }
}
