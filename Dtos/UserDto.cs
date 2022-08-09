namespace TestApp.Dtos
{
    public class UserDto
    {
        public int Id { get;  }
        public string FirstName { get; }
        public string LastName { get; }

        public UserDto(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
