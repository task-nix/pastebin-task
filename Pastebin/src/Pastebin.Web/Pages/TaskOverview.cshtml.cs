using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pastebin.Web.Pages
{
    public class TaskOverviewModel : PageModel
    {
        private readonly ILogger<TaskOverviewModel> _logger;

        public TaskOverviewModel(ILogger<TaskOverviewModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}