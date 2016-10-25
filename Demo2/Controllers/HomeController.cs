using Demo2BAL;
using Demo2Entity;
using Demo2Entity.wsclass;

using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using Omu.AwesomeMvc;
using Omu.Awem;

namespace Demo2.Controllers
{
    public class HomeController : Controller
    {
        
         HttpClient client;
        //The URL of the WEB API Service
         string url = "http://localhost/stpsite/api/HomeAPI/ValidateToken?token=Woqxjo6ZeXvZTwEazpKFosLAtko8L0vyzyMSXmcpk03vBuQCZIPytFWqwpo2MFpXDP8+tBHc6IslaZtJfjcvjg==";

        //[RESTAuthorize]
        public ActionResult Index()
        {
            //new UserBL().GetAll();            
            return View();
        }
   //[ResponseType(typeof(EmployeeInfo))]
         
        //The HttpClient Class, this will be used for performing 
        //HTTP Operations, GET, POST, PUT, DELETE
        //Set the base address and the Header Formatter
        //public HomeController()
        //{
        //    client = new HttpClient();  
        //    client.BaseAddress = new Uri(url);
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
            
        //}
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult PopupConfirm()
        {
            return View();
        }

        public JsonResult HotelSearch()
        {
            
            var client = new RestClient("http://localhost/stpsite/api/HomeAPI/SearchHotel");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);
            var request = new RestRequest(Method.GET) { RequestFormat = DataFormat.Json };
            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string

            return Json(content, JsonRequestBehavior.AllowGet);

        }

        public ActionResult FilterHotel()
        {
            var client = new RestClient("http://localhost/stpsite/api/HomeAPI/FilterHotel");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);
            var request = new RestRequest(Method.GET) { RequestFormat = DataFormat.Json };
            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string

            return Json(content, JsonRequestBehavior.AllowGet);
        }


       

        public void CallService()
        {
            

           
        }
       



        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

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

        public string GetTokenDescriptions(string key, string uId)
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

    }
}