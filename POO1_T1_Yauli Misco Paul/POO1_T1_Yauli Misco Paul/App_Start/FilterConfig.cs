using System.Web;
using System.Web.Mvc;

namespace POO1_T1_Yauli_Misco_Paul
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
