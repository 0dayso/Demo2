using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo2Entity;
using Demo2Entity.wsclass;

namespace Demo2BAL
{
    public class TokenBL
    {
        /// <summary>
        /// Set the token Details
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public string SetUserToken(UserInfo userName)
        {
            int tokenTime = 10;
            LoginStatus objLogin = new LoginStatus();
            Token objToken = new LoginStatusBL().GetUserToken(userName.UserID);

            //string token = EncryptionDecryption.Encode(EncryptionDecryption.SerializeToXmlString<UserInfo>(userName));
            string token = EncryptionDecryption.Encode(userName.UserName);
            //string tokenID=   EncryptionDecryption.GetEncrypt(EncryptionDecryption.SerializeToXmlString<UserInfo>(userName));

            objLogin = null;

            if (objToken.User != string.Empty)
            {

                objToken.TokenExpiretime = DateTime.Now.AddMinutes(tokenTime);
                objToken.TokenValue = token;
                objToken.GUID = objToken.GUID;
                objToken.User = objToken.User;


                string strUpdateQuery = "Update  [dbo].[ServiceToken]   "
                                + " set  [Token]  = '" + objToken.TokenValue + "'"
                                + " ,[ExpireTime] ='" + objToken.TokenExpiretime + "' "
                                + " where  PkServiceTokenId = '" + objToken.GUID + "'";
                //DataObjects.ExecuteQuery(strUpdateQuery);
            }
            else
            {
                objToken.TokenExpiretime = DateTime.Now.AddMinutes(tokenTime);
                objToken.TokenValue = token;
                objToken.GUID = Guid.NewGuid().ToString();
                objToken.User = userName.UserID.ToString().Trim();

                string strQuery = " INSERT INTO [dbo].[ServiceToken]   ([PkServiceTokenId] ,[Token] ,[ExpireTime] ,[UserID] ,[UserType])  " +
                    " VALUES ('" + objToken.GUID + "','" + objToken.TokenValue + "','" + objToken.TokenExpiretime + "', " + objToken.User + " , " + objToken.User + " )";
                //DataObjects.ExecuteQuery(strQuery);

            }
            objToken = null;
            return token;
        }

         #region Public method
        /// <summary>
        /// Get the Existing Token details
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public string GetUserToken(string token)
        {
            //Descript Token
            return string.Empty;
        }

        


        #endregion
    }
}
