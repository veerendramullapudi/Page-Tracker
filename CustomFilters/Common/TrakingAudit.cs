using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomFilters.Common
{
    public class TrakingAudit:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Audit a = new Audit(){
               Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
               ControllerAction = filterContext.ActionDescriptor.ActionName,
               ActionExecuted = filterContext.RouteData.Values["action"].ToString(),
               Date = DateTime.Now.ToString()
            };
            ActionContext context = new ActionContext();
            context.ActionContext.Add(a);
            context.SaveChanges();
        }
    }
}