using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Mvc;
using TokenAuthMVC.Managers;


namespace Demo2
{
    public class ApiAuth
    {
    }

    //public class CustomAuthenticationFilterAttribute : Attribute, IAuthenticationFilter
    //{
    //    public Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    //public async Task AuthenticateAsync(HttpAuthenticationContext context, CancellationToken cancellationToken)
    //    //{
    //    //    await Task.Run(() =>
    //    //    {
    //    //        IPrincipal incomingPrincipal = context.ActionContext.RequestContext.Principal;
    //    //        Debug.WriteLine(String.Format("Incoming principal in custom auth filter AuthenticateAsync method is authenticated: {0}", incomingPrincipal.Identity.IsAuthenticated));
    //    //        IPrincipal genericPrincipal = new GenericPrincipal(new GenericIdentity("Andras", "CustomIdentification"), new string[] { "Admin", "PowerUser" });
    //    //        context.Principal = genericPrincipal;
    //    //    });
    //    //}

    //    public Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    //public async Task ChallengeAsync(HttpAuthenticationChallengeContext context, CancellationToken cancellationToken)
    //    //{
    //    //    await Task.Run(() =>
    //    //    {
    //    //        IPrincipal incomingPrincipal = context.ActionContext.RequestContext.Principal;
    //    //        Debug.WriteLine(String.Format("Incoming principal in custom auth filter ChallengeAsync method is authenticated: {0}", incomingPrincipal.Identity.IsAuthenticated));
    //    //    });
    //    //}
 

    //    public bool AllowMultiple
    //    {
    //        get { throw new NotImplementedException(); }
    //    }
    //}

    public class ApiAuthorizeAttribute : System.Web.Http.AuthorizeAttribute
    {
        private const string _securityToken = "token";
        private string _responseReason = "";
        public bool ByPassAuthorization { get; set; }

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            //logic that will run before even authorizing the customer / user. if this logic fails
            // then the user checking against our custom database table will not processed.
            // you can skip this if you don't have such requirements and directly call
            //if (IsApiPageRequested(actionContext))
            if (true)
            {
                //if (!this.IsPluginAvailableForCurrentStore())
                if (true)
                {
                    this.HandleUnauthorizedRequest(actionContext);
                    _responseReason = "Web services plugin is not available in this store";
                }
                else
                {
                    base.OnAuthorization(actionContext);
                }
            }

        }



        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Forbidden);
            if (!string.IsNullOrEmpty(_responseReason))
                actionContext.Response.ReasonPhrase = _responseReason;
        }
        //private IEnumerable<apiauthorizeattribute> GetApiAuthorizeAttributes(HttpActionDescriptor descriptor)
        //{
        //    return descriptor.GetCustomAttributes<apiauthorizeattribute>(true)
        //        .Concat(descriptor.ControllerDescriptor.GetCustomAttributes<apiauthorizeattribute>(true));
        //}

        //private bool IsApiPageRequested(HttpActionContext actionContext)
        //{

        //    var apiAttributes = GetApiAuthorizeAttributes(actionContext.ActionDescriptor);
        //    if (apiAttributes != null && apiAttributes.Any())
        //        return true;
        //    return false;
        //}

        //private bool HasWebServiceAccess()
        //{
        //    //_permissionService is our custom service that calls Authorize() method which goes to the custom table in database and check if current user has some permission the reply back with true or false
        //    return new UserBL().Authorize(HttpContext.Current.User);

        //    bool result = _permissionService.Authorize(HttpContext.Current.User);
        //    return result;
        //}


        //protected override bool IsAuthorized(HttpActionContext actionContext)
        //{
        //    //logic for check whether we have an attribute with ByPassAuthorization = true e.g [ByPassAuthorization(true)], if so then just return true 
        //    if (ByPassAuthorization
        //        || GetApiAuthorizeAttributes(actionContext.ActionDescriptor).Any(x => x.ByPassAuthorization))
        //        return true;
        //    //checking against our custom table goes here
        //    if (!this.HasWebServiceAccess())
        //    {
        //        this.HandleUnauthorizedRequest(actionContext);
        //        _responseReason = "Access Denied";
        //        return false;
        //    }

        //    return base.IsAuthorized(actionContext);
        //}

    }
}