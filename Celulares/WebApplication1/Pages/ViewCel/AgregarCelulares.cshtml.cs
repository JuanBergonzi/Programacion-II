using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Celulares;
using Celulares.Celulares;
using CLogica.Implementation.Contracts;

namespace WebApplication1.Pages.ViewCel
{
    public class AgregarCelularesModel : PageModel
    {
        private readonly ICelularService _service;
        public AgregarCelularesModel(ICelularService service) => _service = service;

        [BindProperty]
        public Celular Celular { get; set; } = new();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            _service.AgregarCelulares(Celular);
            return RedirectToPage("listaCelulares");
        }
    }
}
