﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAL.Modelo;

namespace ProyectoFinalCsPharma.Pages.EstadosEnvioPedido
{
    public class DeleteModel : PageModel
    {
        private readonly DAL.Modelo.CspharmaInformacionalContext _context;

        public DeleteModel(DAL.Modelo.CspharmaInformacionalContext context)
        {
            _context = context;
        }

        [BindProperty]
      public TdcCatEstadosEnvioPedido TdcCatEstadosEnvioPedido { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.TdcCatEstadosEnvioPedidos == null)
            {
                return NotFound();
            }

            var tdccatestadosenviopedido = await _context.TdcCatEstadosEnvioPedidos.FirstOrDefaultAsync(m => m.CodEstadoEnvio == id);

            if (tdccatestadosenviopedido == null)
            {
                return NotFound();
            }
            else 
            {
                TdcCatEstadosEnvioPedido = tdccatestadosenviopedido;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null || _context.TdcCatEstadosEnvioPedidos == null)
            {
                return NotFound();
            }
            var tdccatestadosenviopedido = await _context.TdcCatEstadosEnvioPedidos.FindAsync(id);

            if (tdccatestadosenviopedido != null)
            {
                TdcCatEstadosEnvioPedido = tdccatestadosenviopedido;
                _context.TdcCatEstadosEnvioPedidos.Remove(TdcCatEstadosEnvioPedido);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
