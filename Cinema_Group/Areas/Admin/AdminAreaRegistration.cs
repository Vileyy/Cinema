using System.Web.Mvc;

namespace Cinema_Group.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Cinema-Group", id = UrlParameter.Optional }
                ,namespaces: new[] {"Cinema_Group.Controllers"}
            );
        }
    }
}