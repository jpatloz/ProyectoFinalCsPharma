﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAL.Modelo;

namespace ProyectoFinalCsPharma.Pages.EstadoPedido
{
    public class IndexModel : PageModel
    {
        private readonly DAL.Modelo.CspharmaInformacionalContext _context;

        public IndexModel(DAL.Modelo.CspharmaInformacionalContext context)
        {
            _context = context;
        }

        public IList<TdcTchEstadoPedido> TdcTchEstadoPedido { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.TdcTchEstadoPedidos != null)
            {
                TdcTchEstadoPedido = await _context.TdcTchEstadoPedidos
                .Include(t => t.CodEstadoDevolucionNavigation)
                .Include(t => t.CodEstadoEnvioNavigation)
                .Include(t => t.CodEstadoPagoNavigation)
                .Include(t => t.CodLineaNavigation).ToListAsync();
            }
        }
    }
}
