using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;
using TokenAuthMVC.Managers;

namespace Demo2
{
   public class RESTAuthorizeAttribute : AuthorizeAttribute
{
    private const string _securityToken = "token"; // Name of the url parameter.
    public override void OnAuthorization(AuthorizationContext filterContext)
    {
        if (Authorize(filterContext))
        {
            return;
        }
        HandleUnauthorizedRequest(filterContext);
    }
    protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
    {
        base.HandleUnauthorizedRequest(filterContext);
    }
    private bool Authorize(AuthorizationContext actionContext)
    {
        try
        {
            HttpRequestBase request = actionContext.RequestContext.HttpContext.Request;
            string token = request.Params[_securityToken];
            return SecurityManager.IsTokenValid(token, CommonManager.GetIP(request), request.UserAgent);
        }
        catch (Exception)
        {
            return false;
        }
    }
}


   


}