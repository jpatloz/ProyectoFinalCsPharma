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
    public class DeleteModel : PageModel
    {
        private readonly DAL.Modelo.CspharmaInformacionalContext _context;

        public DeleteModel(DAL.Modelo.CspharmaInformacionalContext context)
        {
            _context = context;
        }

        [BindProperty]
      public TdcTchEstadoPedido TdcTchEstadoPedido { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null || _context.TdcTchEstadoPedidos == null)
            {
                return NotFound();
            }

            var tdctchestadopedido = await _context.TdcTchEstadoPedidos.FirstOrDefaultAsync(m => m.Id == id);

            if (tdctchestadopedido == null)
            {
                return NotFound();
            }
            else 
            {
                TdcTchEstadoPedido = tdctchestadopedido;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null || _context.TdcTchEstadoPedidos == null)
            {
                return NotFound();
            }
            var tdctchestadopedido = await _context.TdcTchEstadoPedidos.FindAsync(id);

            if (tdctchestadopedido != null)
            {
                TdcTchEstadoPedido = tdctchestadopedido;
                _context.TdcTchEstadoPedidos.Remove(TdcTchEstadoPedido);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
