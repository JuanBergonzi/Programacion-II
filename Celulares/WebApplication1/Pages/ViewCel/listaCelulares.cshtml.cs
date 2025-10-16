using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Celulares;
using System.Collections.Generic;
using Celulares.Celulares;
using CLogica.Implementation.Contracts;

namespace WebApplication1.Pages.ViewCel
{
    public class listaCelularesModel : PageModel
    {
        private readonly ICelularService _service;
        public listaCelularesModel(ICelularService service) => _service = service;

        public List<Celular> Celulares { get; set; } = new();

        public void OnGet()
        {
            Celulares = _service.GetCelulares();
        }
    }
}   
