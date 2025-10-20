namespace Login.Shared
{
    public static class UserDatabase
    {
        public static List<UserAccount> Accounts { get; } = new List<UserAccount>();
    }

    public class UserAccount
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
