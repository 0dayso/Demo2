using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TokenAuthMVC.Managers
{
    /// <summary>
    /// Token-based authentication for ASP .NET MVC REST web services.
    /// Copyright (c) 2015 Kory Becker
    /// http://primaryobjects.com/kory-becker
    /// License MIT
    /// </summary>
    public static class CommonManager
    {
        public static string GetIP(HttpRequestBase request)
        {
            string ip = request.Headers["X-Forwarded-For"]; // AWS compatibility

            if (string.IsNullOrEmpty(ip))
            {
                ip = request.UserHostAddress;
            }

            return ip;
        }
    }


    public interface IServerDataRestClient
    {
        //void Add(Demo2Entity.Hotel_Search_RQ model);
        //void Delete(int id);
        //IEnumerable<Demo2Entity.Hotel_Search_RQ> GetAll();
        //Demo2Entity.Hotel_Search_Result GetById(int id);
        //Demo2Entity.Hotel_Search_Result GetByIP(int ip);
        //Demo2Entity.Hotel_Search_Result GetByType(int type);
        ////void Update(ServerDataModel serverDataModel);

        IEnumerable<Demo2Entity.Hotel_Search_RQ> GetAll();
    } 

}
