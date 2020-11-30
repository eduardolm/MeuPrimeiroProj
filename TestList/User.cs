namespace TestList
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public int Admin { get; set; }

        public User(int id, string fullName, string email, string username, string password, string phone, int admin)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            Username = username;
            Password = password;
            Phone = phone;
            Admin = admin;
        }
    }
}