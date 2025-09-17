using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Dynamic;

namespace UserDataAppCore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public string UserName { get; set; }

        [BindProperty]
        public string UserEmail { get; set; } 

        public bool Stored { get; set; }  

        public void OnGet()
        {

        }

        public void OnPost() 
        {
            TempData["UserName"] = UserName;
            TempData["UserEmail"] = UserEmail;

            Stored = true;
        }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

       
    }
}
