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
    public class IndexModel : PageModel
    {
        private readonly DAL.Modelo.CspharmaInformacionalContext _context;

        public IndexModel(DAL.Modelo.CspharmaInformacionalContext context)
        {
            _context = context;
        }

        public IList<TdcCatLineasDistribucion> TdcCatLineasDistribucion { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.TdcCatLineasDistribucions != null)
            {
                TdcCatLineasDistribucion = await _context.TdcCatLineasDistribucions.ToListAsync();
            }
        }
    }
}
