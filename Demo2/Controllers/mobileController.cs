using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web;
using Demo2Entity;
using TokenAuthMVC.Managers;
using Demo2BAL;
using Demo2Entity.wsclass;
//using Demo2Entity.wsclass;
using System.IO;
using System.Web.Routing;
//using System.Web.Http;
using System.Web.Http.WebHost;

namespace Demo2.Controllers
{
    
    public class mobileController : ApiController
    {
        /*
        [System.Web.Http.HttpGet]
        public List<User> GetAll()
        {
            Demo2Entity.wsclass.UserInfo objUserInfo = new Demo2Entity.wsclass.UserInfo();
            //return new UserBL().GetAll().ToList();
            string strToken= new TokenBL().SetUserToken(objUserInfo);
            return null;
        }
        [System.Web.Http.HttpGet]
        // GET api/<controller>
        public IEnumerable<string> Getarr(string token)
        {
            return new string[] { "value1", "value2" };
        }

         //GET api/<controller>/5
        //[RESTAuthorize]

        */
        [System.Web.Http.HttpGet]
        public string Get(int id)
        {
             Demo2Entity.wsclass.UserInfo objUserInfo = new Demo2Entity.wsclass.UserInfo();
             objUserInfo.UserID = 12;
             objUserInfo.UserName = "Admin";
             objUserInfo.UserPassword = "asdfasdfadf";

            //return new UserBL().GetAll().ToList();
            string strToken= new TokenBL().SetUserToken(objUserInfo);
            return strToken;
        }
        
        /*
        
        [System.Web.Http.HttpGet]
        [ApiAuthorize]
        public string GetToken(string uid,string pwd)
        {
            return SecurityManager.GenerateToken(uid, pwd, "127.1.1.1", "agentvinod", 10);
        }
        
        //[System.Web.Routing.Route("api/mobile/CheckUser")]
        
        //[HttpGet]
        public string CheckUser(string user)
        {
            Demo2Entity.wsclass.UserInfo objUserInfo = new Demo2Entity.wsclass.UserInfo();
            //objUserInfo.UserID = id;
            //return new TokenBL().SetUserToken(objUserInfo);
            return "vijay";
        }

        [System.Web.Http.HttpGet]
        public string GetMethod(string token, string fly)
        {
            return token;
        }
        [System.Web.Http.HttpGet]
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
        [System.Web.Http.HttpGet]
        public string GetTicketDescriptions(string key, string uId)
        {
            try
            {
                LoginStatusBL loginStatus = new LoginStatusBL();
                UserInfo user = loginStatus.ValidateToken(key);
                if (user != null)
                    return "Token not is called for uid " + uId;
                else
                    throw new Exception("UnAutorize person to acess");

                
            }
            catch (Exception ex)
            {
               // throw new WebFaultException<string>(ex.Message.ToString(), HttpStatusCode.Unauthorized);
            }
            return string.Empty;
        }
        
         */

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}