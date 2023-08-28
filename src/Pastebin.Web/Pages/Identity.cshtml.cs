using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pastebin.Web.Pages
{
    public class IdentityModel : PageModel
    {
        private readonly ILogger<IdentityModel> _logger;

        public IdentityModel(ILogger<IdentityModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}