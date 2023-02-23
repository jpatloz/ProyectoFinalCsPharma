using DAL.Modelo;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinalCsPharma.Pages.ListaUsuarios
{
    public class IndexModel : PageModel
    {
        private readonly Areas.Identity.Data.LoginRegisterContext _context;

        public IndexModel(Areas.Identity.Data.LoginRegisterContext context)
        {
            _context = context;
        }

        public IList<IdentityRole> Dlk_cat_acc_roles { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Dlk_cat_acc_roles != null)
            {
                Dlk_cat_acc_roles = await _context.Dlk_cat_acc_roles.ToListAsync();
            }
        }
    }
}
