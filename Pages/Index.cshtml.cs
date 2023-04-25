using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HW_24._04.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Login { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            ViewData["login"] = Login;
            ViewData["password"] = Password;
        }
    }
}