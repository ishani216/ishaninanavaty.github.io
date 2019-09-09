using System.Web;
using System.Web.Mvc;

namespace Lab_2_IT_2030_INanavaty
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
