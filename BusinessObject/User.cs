using System;
namespace BusinessObject
{
    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
        public String FullName { get; set; }

        public User()
        {
        }

        public User(int id, string name, string password, string fullName)
        {
            Id = id;
            Name = name;
            Password = password;
            FullName = fullName;
        }
    }
}
