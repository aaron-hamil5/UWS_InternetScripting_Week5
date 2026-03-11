using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthwindContext;

namespace NorthwindWeb.Pages
{
    public class ModifyCustomers : PageModel
    {
        public Customer ModCus {get; set;} = new Customer();

        public IActionResult OnGet(int customerID)
        {
            NorthwindDatabase db = new NorthwindDatabase();
            ModCus = db.Customers.Single(c => c.CustomerID == customerID);
            return Page();
        }

        public void OnPost()
        {
            NorthwindDatabase db = new NorthwindDatabase();
            
        }
    }
}