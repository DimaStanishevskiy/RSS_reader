using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSS_reader.Classes
{
    class User
    {
        public string Email;

        public string Password;

        public string Token;

        public User(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
    }
}
