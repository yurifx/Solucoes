using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Filter_Creation
{
    class Program
    {
        
        static void Main(string[] args)
        {

        }
    }


    public class AuthorizeFilter : System.Web.Mvc.ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var req = HttpContext.Current.Request.Cookies["mycookie"].Value.Replace("Login:", string.Empty).Replace("Senha:", string.Empty).Split('|');
            var login = req[0];
            var senha = req[1];
            using (var db = new Banco())
            {
                if (!db.Users.Any(x => x.Login == login && x.Password == senha))
                {
                    HttpContext.Current.Response.Redirect("/Login");
                }
            }
        }
    }

}
