using Demo2Entity;
using Demo2Entity.wsclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2BAL
{
    public class LoginStatusBL
    {
        /// <summary>
        /// Return Token Object with value
        /// </summary>
        /// <param name="pUseId"></param>
        /// <returns></returns>
        public Token GetUserToken(long pUseId)
        {
            Token objToken = new Token();
            ////"select * from  ServiceToken where UserID =" + pUseId + " and ExpireTime >'" + DateTime.Now + "'");
            ////if (dtData != null && dtData.Rows.Count > 0)
            ////{
            ////    DataRow dr = dtData.Rows[0];
            //objToken.User = "1";
            //objToken.TokenExpiretime = DateTime.Now.AddMinutes(10);
            //objToken.GUID = new Guid().ToString();
            //objToken.TokenValue = "TESSDFSDFSDFSDFXXXXXXX";
            ////}

            return objToken;
        }

        /// <summary>
        /// Check the Login Information
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="serviceCenterId"></param>
        /// <returns></returns>
        public UserInfo DoLoginInfo(string username, string password)
        {
            if (username.Trim().ToLower() == "vijay" && password.Trim() == "vijaypwd")
            {
                UserInfo objUserInfo = new UserInfo();
                objUserInfo.UserID = 99;
                objUserInfo.UserName = "vijay";
                //objUserInfo.UserPassword = "Test";
                return objUserInfo;
            }
            return null;
        }

        public UserInfo ValidateToken(string token)
        {
            Token objToken = new Token();
            string Query = "select * from  ServiceToken where Token ='" + token + "' and ExpireTime >'" + DateTime.Now + "'";
            //DataSet dsResult = DataObjects.ExecuteDataSet(Query);
            //if (dsResult != null && dsResult.Tables[0] != null && dsResult.Tables.Count > 0)
            //{
            //    DataTable dtData = dsResult.Tables[0];
            //    dtData.TableName = dsResult.Tables[0].TableName;
            //    if (dtData != null && dtData.Rows.Count > 0)
            //    {
            //        return EncryptionDecryption.DeserializeXmlString<UserInfo>(EncryptionDecryption.Decode(token));
            //    }
            //}
            
            //return EncryptionDecryption.DeserializeXmlString<UserInfo>(EncryptionDecryption.Decode(token));
            string strDecode =  EncryptionDecryption.Decode(token);
            return new UserInfo { UserID = 99, UserName = "vijay", UserPassword = "vijaypwd" };
        }
    }
}
