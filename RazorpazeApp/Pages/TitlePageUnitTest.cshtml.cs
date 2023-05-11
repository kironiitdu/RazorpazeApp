using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorpazeApp.Pages
{
    public class TitlePageUnitTestModel : PageModel
    {
        private readonly ILogger<TitlePageUnitTestModel> _logger;

        public string? Title { get; set; }

        public TitlePageUnitTestModel(ILogger<TitlePageUnitTestModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Title"] = "Home page";
            Title = ViewData["Title"]?.ToString() ?? "";
        }
    }
}
