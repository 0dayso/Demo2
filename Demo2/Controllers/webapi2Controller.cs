using Demo2BAL;
using Demo2Entity.wsclass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo2.Controllers
{
    public class webapi2Controller : ApiController
    {

        public string AuthenticateUser(string Username, string Password)
        {
            string strResult = string.Empty;
            try
            {
                LoginStatusBL objBL = new LoginStatusBL();

                // code for check login method
                UserInfo userInfo = objBL.DoLoginInfo(Username, Password);

                if (userInfo != null)
                {
                    TokenBL objToken = new TokenBL();
                    string token = objToken.SetUserToken(userInfo);
                    //Response.Headers.Add("token", token);
                    return token;
                }
                else
                {
                    throw new Exception("Unable to Authorize.");
                }
            }
            catch (WebException ex)
            {
                strResult = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
            }
            catch (Exception ex)
            {
                strResult = ex.Message;
            }
            return strResult;
        }

    }
}
