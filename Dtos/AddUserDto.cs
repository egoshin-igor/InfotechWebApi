namespace TestApp.Dtos
{
    public class AddUserDto
    {
        public string UserName { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Password { get; }

        public AddUserDto(string userName, string firstName, string lastName, string password)
        {
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
        }
    }
}
