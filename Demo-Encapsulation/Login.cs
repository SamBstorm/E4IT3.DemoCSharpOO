using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Encapsulation
{
    internal class Login
    {
        private string _username;

        public string Password { private get; set; }

        public string Username
        {
            private get
            {
                return _username;
            }
            set
            {
                _username = value.Trim();
                if (_username == "Admin") Password = "Admin";
            }
        }

        public bool CheckUser(string user_name, string pwd)
        {
            return user_name == _username && Password == pwd;
        }

        //SNIPPETS :
        //prop : permet de créer une auto-propriété
        //propfull : permet de créer une propriété et sa variable déjà lié
    }
}
