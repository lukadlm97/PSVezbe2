using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageUsers
{
    public class StorageUsers
    {
        private List<User> _users;

        public List<User> Users
        {
            get { return _users; }
            set { _users = value; }
        }

        public StorageUsers()
        {
            _users = new List<User>();
            User u = new User();
            u.Name = "Luka Radovanovic";
            u.Email = "lukadlm97@gmail.com";
            u.Username = "lukadlm";
            u.Password = "luka";

            User u1 = new User();
            u1.Name = "Nina Radovanovic";
            u1.Email = "nina@gmail.com";
            u1.Username = "nina";
            u1.Password = "nina";

            _users.Add(u);
            _users.Add(u1);
        }

        public List<User> AllUsers()
        {
            if (_users == null)
                return null;
            return _users;
        }

        public bool AddUser(User newUser)
        {
            if (newUser == null)
                return false;
            _users.Add(newUser);
            return true;
        }
    }
}
