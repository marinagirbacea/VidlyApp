using System.Web;
using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());//this filter redirects to user error page when an action throws
                                                    //an exception
            filters.Add(new AuthorizeAttribute());
           // filters.Add(new RequireHttpsAttribute());

        }
    }
}
