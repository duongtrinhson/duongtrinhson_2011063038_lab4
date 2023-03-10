using System.Web;
using System.Web.Mvc;

namespace duongtrinhson_2011063038_lab4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
