using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealtyModel.Events.Identity
{
    public class LoggingInEventArgs
    {
        private String userName = "";
        private String password = "";

        public LoggingInEventArgs(String userName, String password)
        {
            this.userName = userName;
            this.password = password;
        }

        public String UserName { get => userName; set => userName = value; }
        public String Password { get => password; set => password = value; }
    }
}
