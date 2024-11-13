using UAS_DB_PamerYuk.F2_Friendship;

namespace UAS_DB_PamerYuk.F4_Content
{
    public class FriendshipService
    {
        private readonly FriendshipRepo repo;

        public FriendshipService(FriendshipRepo repo) { this.repo = repo; }
    }
}
