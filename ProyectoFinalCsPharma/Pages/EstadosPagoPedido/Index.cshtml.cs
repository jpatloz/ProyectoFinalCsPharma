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
    public class IndexModel : PageModel
    {
        private readonly DAL.Modelo.CspharmaInformacionalContext _context;

        public IndexModel(DAL.Modelo.CspharmaInformacionalContext context)
        {
            _context = context;
        }

        public IList<TdcCatEstadosPagoPedido> TdcCatEstadosPagoPedido { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.TdcCatEstadosPagoPedido != null)
            {
                TdcCatEstadosPagoPedido = await _context.TdcCatEstadosPagoPedido.ToListAsync();
            }
        }
    }
}
