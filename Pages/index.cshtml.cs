using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NorthwindWeb.Pages
{
    public class ViewCustomers : PageModel
    {
        public String DbName {get; set;}

        public void OnGet()
        {
            DbName = "Customers";
        }
    }
}