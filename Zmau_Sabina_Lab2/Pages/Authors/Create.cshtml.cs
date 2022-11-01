using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zmau_Sabina_Lab2.Models;

namespace Zmau_Sabina_Lab2.Pages.Authors
{
    public class CreateModel : PageModel
    {
        private readonly Zmau_Sabina_Lab2.Data.Zmau_Sabina_Lab2Context _context;

        public CreateModel(Zmau_Sabina_Lab2.Data.Zmau_Sabina_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Author Author { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Author.Add(Author);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
