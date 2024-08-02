using System.Web;
using System.Web.Mvc;

namespace _3_MVCApiCLient
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new HandleErrorAttribute()); 
            //l'ajout de cette ligne aura pour conséquence, : tous les controllers de l'applicationseront filtrés

        }
    }
}
