using UAS_DB_PamerYuk.F3_Chat;

namespace UAS_DB_PamerYuk.F1_UserManager
{
    public class ChatService
    {
        private readonly ChatRepo repo;

        public ChatService(ChatRepo repo) { this.repo = repo; }
    }
}
