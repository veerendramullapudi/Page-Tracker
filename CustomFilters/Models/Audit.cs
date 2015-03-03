using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomFilters.Models
{
    public class Audit
    {
        public Guid Id { get; set; }
        public string Controller { get; set; }
        public string ControllerAction { get; set; }
        public string ActionExecuted { get; set; }
        public DateTime Date { get; set; }
    }
    public class AuditContext:DbContext
    {
         public AuditContext()
            : base("DefaultConnection") { }
        public DbSet<Audit> ActionContext { set; get; }
    }
}