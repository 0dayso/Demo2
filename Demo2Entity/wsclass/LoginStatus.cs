using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2Entity.wsclass
{
    public class LoginStatus
    {
        public LoginStatus() { }

        public LoginStatus(string token)
        {
        }

        private string _token = string.Empty;
        private string _message = string.Empty;
        private bool _success = false;

        public bool Success
        {
            get { return _success; }
            set { _success = value; }
        }

        
        public string Token
        {
            get { return _token; }
            set { _token = value; }
        }

        
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        

    }
}
