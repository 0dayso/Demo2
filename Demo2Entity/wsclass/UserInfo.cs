using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2Entity.wsclass
{
    
    public class UserInfo
    {
        private long _userId = 0;
        private string _userName = string.Empty;
        private string _userPassword = string.Empty;

        public long UserID
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string UserPassword
        {
            get { return _userPassword; }
            set { _userPassword = value; }
        }

    }
}
