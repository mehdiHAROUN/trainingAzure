using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication.Pages
{
    public class ErreurModel : PageModel
    {
        public void OnGet()
        {
            int a = 1;
            int b = 0 ;
           var c = a / b;
        }
    }
}
