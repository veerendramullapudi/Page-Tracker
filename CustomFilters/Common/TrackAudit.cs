using CustomFilters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomFilters.Common
{
    public class TrackAudit : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Audit a = new Audit()
            {
                Id= Guid.NewGuid(),
                Controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
                ControllerAction = filterContext.ActionDescriptor.ActionName,
                ActionExecuted = filterContext.RouteData.Values["action"].ToString(),
                Date = DateTime.Now
            };
            AuditContext context = new AuditContext();
            context.ActionContext.Add(a);
            context.SaveChanges();
        }
    }
}