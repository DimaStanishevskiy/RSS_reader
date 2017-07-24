using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSS_reader.Models
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Token {get; set; }

        public User(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }
    }
}
