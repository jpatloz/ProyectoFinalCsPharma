using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAL.Modelo;

namespace ProyectoFinalCsPharma.Pages.EstadosPagoPedido
{
    public class DetailsModel : PageModel
    {
        private readonly DAL.Modelo.CspharmaInformacionalContext _context;

        public DetailsModel(DAL.Modelo.CspharmaInformacionalContext context)
        {
            _context = context;
        }

      public TdcCatEstadosPagoPedido TdcCatEstadosPagoPedido { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.TdcCatEstadosPagoPedido == null)
            {
                return NotFound();
            }

            var tdccatestadospagopedido = await _context.TdcCatEstadosPagoPedido.FirstOrDefaultAsync(m => m.CodEstadoPago == id);
            if (tdccatestadospagopedido == null)
            {
                return NotFound();
            }
            else 
            {
                TdcCatEstadosPagoPedido = tdccatestadospagopedido;
            }
            return Page();
        }
    }
}
