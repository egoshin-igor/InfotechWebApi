namespace TestApp.Application.Services.Models
{
    public class AddUser
    {
        public string UserName { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Password { get; }

        public AddUser(string userName, string firstName, string lastName, string password)
        {
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
        }
    }
}
