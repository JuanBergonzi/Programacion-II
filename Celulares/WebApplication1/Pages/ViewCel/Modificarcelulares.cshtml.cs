using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Celulares;
using Celulares.Celulares;
using CLogica.Implementation.Contracts;

namespace WebApplication1.Pages.ViewCel
{
    public class ModificarcelularesModel : PageModel
    {
        private readonly ICelularService _service;
        public ModificarcelularesModel(ICelularService service) => _service = service;

        [BindProperty]
        public Celular Celular { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            var existente = _service.GetById(id);
            if (existente == null) return RedirectToPage("listaCelulares");
            Celular = existente;
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            _service.Update(Celular);
            return RedirectToPage("listaCelulares");
        }
    }
}
