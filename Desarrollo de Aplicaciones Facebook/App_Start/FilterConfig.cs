using System.Web;
using System.Web.Mvc;

namespace Desarrollo_de_Aplicaciones_Facebook
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
