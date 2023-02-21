using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DAL.Modelo;

namespace ProyectoFinalCsPharma.Pages.EstadosPagoPedido
{
    public class EditModel : PageModel
    {
        private readonly DAL.Modelo.CspharmaInformacionalContext _context;

        public EditModel(DAL.Modelo.CspharmaInformacionalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TdcCatEstadosPagoPedido TdcCatEstadosPagoPedido { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.TdcCatEstadosPagoPedido == null)
            {
                return NotFound();
            }

            var tdccatestadospagopedido =  await _context.TdcCatEstadosPagoPedido.FirstOrDefaultAsync(m => m.CodEstadoPago == id);
            if (tdccatestadospagopedido == null)
            {
                return NotFound();
            }
            TdcCatEstadosPagoPedido = tdccatestadospagopedido;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TdcCatEstadosPagoPedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TdcCatEstadosPagoPedidoExists(TdcCatEstadosPagoPedido.CodEstadoPago))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TdcCatEstadosPagoPedidoExists(string id)
        {
          return _context.TdcCatEstadosPagoPedido.Any(e => e.CodEstadoPago == id);
        }
    }
}
