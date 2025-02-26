namespace UserInterface.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users;

        public UserAccountService()
        {

            _users = new List<UserAccount>
            {
               new UserAccount{UserName = "admin",Password="admin", Role ="Administrator"},
               new UserAccount{UserName = "aniqa",Password="aniqa", Role ="Administrator"},
               new UserAccount{UserName = "user",Password="user",Role ="User"},
               new UserAccount{UserName = "aniqa",Password="aniqa",Role ="User"},

            };


        }

        public UserAccount? GetByUserAccount(string userName)
        {
            return _users.FirstOrDefault(x => x.UserName == userName);
        }
    }
}
