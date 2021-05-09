using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Events.Identity
{
    public class RegisteringEventArgs
    {
        private String userName = "";
        private String password = "";
        private String email = "";

        public RegisteringEventArgs(String userName, String password, String email)
        {
            this.userName = userName;
            this.password = password;
            this.email = email;
        }

        public String UserName { get => userName; set => userName = value; }
        public String Password { get => password; set => password = value; }
        public String Email { get => email; set => email = value; }
    }
}
