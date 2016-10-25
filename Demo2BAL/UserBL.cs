using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo2Entity;
using System.Configuration;
using System.Web;
using System.Data.Entity.Core.EntityClient;

namespace Demo2BAL
{
    public class UserBL
    {

        private string _dbCon;
        //public UserBL()
        //{
        //    //_dbCon = "metadata=res://*/EMR.csdl|res://*/EMR.ssdl|res://*/EMR.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=SERVER-PC\SQLEXPRESS;initial catalog=EMR;user id=sa;password=sa123;MultipleActiveResultSets=True;App=EntityFramework&quot;";
        //}

        private string dbCon
        {
            get { return _dbCon; }
        }

        public List<User> GetAll()
        {
            using(var ctx = new EMREntities(dbCon))
            {
		        return ctx.Users.Where(x=>x.IsProvider == false).ToList();
            }
            
        }




        public bool Authorize(string user)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
