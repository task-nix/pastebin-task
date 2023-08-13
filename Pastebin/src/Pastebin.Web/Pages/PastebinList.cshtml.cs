using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pastebin.Web.Pages
{
    public class PasteBinListModel : PageModel
    {
        private readonly ILogger<PasteBinListModel> _logger;

        public PasteBinListModel(ILogger<PasteBinListModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}