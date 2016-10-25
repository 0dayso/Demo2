using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2Entity.wsclass
{
    public class Token
    {
        #region Variable  Declaration
        private string _user;
        private string _guid;
        private string _tokenvalue;
        private DateTime _tokenExpiretime;
        #endregion

        #region Constructor
        public Token() { }

        //public Token(string token)
        //{
        //    //GetUserToken(token);
        //}
        #endregion

        #region Property

        public string User
        {
            get { return _user; }
            set { _user = value; }
        }

        public string GUID
        {
            get { return _guid; }
            set { _guid = value; }
        }

        public string TokenValue
        {
            get { return _tokenvalue; }
            set { _tokenvalue = value; }
        }

        public DateTime TokenExpiretime
        {
            get { return _tokenExpiretime; }
            set { _tokenExpiretime = value; }
        }

        #endregion

       
    }
}
