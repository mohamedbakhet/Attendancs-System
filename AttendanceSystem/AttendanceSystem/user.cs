using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    class user
    {
        string name;
        string email;
        string password;
        int id;

        public user() { }

        public user(string name, string email, string password, int id)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.id = id;
        }
    }
}
