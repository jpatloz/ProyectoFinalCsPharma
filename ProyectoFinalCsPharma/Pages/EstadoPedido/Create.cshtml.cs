using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DAL.Modelo;

namespace ProyectoFinalCsPharma.Pages.EstadoPedido
{
    public class CreateModel : PageModel
    {
        private readonly DAL.Modelo.CspharmaInformacionalContext _context;

        public CreateModel(DAL.Modelo.CspharmaInformacionalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CodEstadoDevolucion"] = new SelectList(_context.TdcCatEstadosDevolucionPedidos, "CodEstadoDevolucion", "CodEstadoDevolucion");
        ViewData["CodEstadoEnvio"] = new SelectList(_context.TdcCatEstadosEnvioPedidos, "CodEstadoEnvio", "CodEstadoEnvio");
        ViewData["CodEstadoPago"] = new SelectList(_context.TdcCatEstadosPagoPedido, "CodEstadoPago", "CodEstadoPago");
        ViewData["CodLinea"] = new SelectList(_context.TdcCatLineasDistribucions, "CodLinea", "CodLinea");
            return Page();
        }

        [BindProperty]
        public TdcTchEstadoPedido TdcTchEstadoPedido { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TdcTchEstadoPedidos.Add(TdcTchEstadoPedido);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
