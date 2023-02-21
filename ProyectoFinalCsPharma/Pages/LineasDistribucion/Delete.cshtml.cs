﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAL.Modelo;

namespace ProyectoFinalCsPharma.Pages.LineasDistribucion
{
    public class DeleteModel : PageModel
    {
        private readonly DAL.Modelo.CspharmaInformacionalContext _context;

        public DeleteModel(DAL.Modelo.CspharmaInformacionalContext context)
        {
            _context = context;
        }

        [BindProperty]
      public TdcCatLineasDistribucion TdcCatLineasDistribucion { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.TdcCatLineasDistribucions == null)
            {
                return NotFound();
            }

            var tdccatlineasdistribucion = await _context.TdcCatLineasDistribucions.FirstOrDefaultAsync(m => m.CodLinea == id);

            if (tdccatlineasdistribucion == null)
            {
                return NotFound();
            }
            else 
            {
                TdcCatLineasDistribucion = tdccatlineasdistribucion;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null || _context.TdcCatLineasDistribucions == null)
            {
                return NotFound();
            }
            var tdccatlineasdistribucion = await _context.TdcCatLineasDistribucions.FindAsync(id);

            if (tdccatlineasdistribucion != null)
            {
                TdcCatLineasDistribucion = tdccatlineasdistribucion;
                _context.TdcCatLineasDistribucions.Remove(TdcCatLineasDistribucion);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
