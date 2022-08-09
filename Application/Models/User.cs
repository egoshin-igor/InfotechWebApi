namespace TestApp.Application.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string UserName { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Password  { get; private set; }

        public User(string userName, string firstName, string lastName, string password)
        {
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
        }

        internal void DefineId( int id )
        {
            if ( Id > 0 )
            {
                throw new Exception( $"New id: {id} cannot be set. Id: {Id} already defined" );
            }

            Id = id;
        }
    }
}
