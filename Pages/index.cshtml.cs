using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthwindContext;

namespace NorthwindWeb.Pages
{
    public class ViewCustomers : PageModel
    {
        public String DbName {get; set;}
        public List<Customer> Customers {get; set;}

        public void OnGet()
        {
            DbName = "Customers";
            NorthwindDatabase db = new NorthwindDatabase();
            Customers = db.Customers.ToList();
        }
    }
}