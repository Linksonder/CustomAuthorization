using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CustomAuhtorization.Models
{
    public class StinoAuthorizeAttribute : AuthorizeAttribute
    {
        public string WhatMyName { get; set; }



        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (WhatMyName == "Stino")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary(
                            new
                            {
                                controller = "My",
                                action = "Redirect"
                            })
                        );
        }
    }

}