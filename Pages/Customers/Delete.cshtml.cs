using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;
           

namespace SupermarketWEB.Pages.Customers
{
    public class DeleteModel : PageModel
    {
        private readonly SupermarketContext _context;
        public DeleteModel(SupermarketContext context)
        {
            _context = context;
        }

        [BindProperty]

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Customers = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);


            if (Customer == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Customers = await _context.Products.FindAsync(id);

            if (Customer != null)
            {
                Customer = Customer;
                _context.Customers.Remove(Customer);
                await _context.SaveChangesAsync();

            }

            return RedirectToPage("./Index");
        }
    }
}
