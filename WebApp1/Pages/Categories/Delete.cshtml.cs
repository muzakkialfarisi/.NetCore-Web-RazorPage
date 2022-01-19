using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp1.Data;
using WebApp1.Model;

namespace WebApp1.Pages.Categories
{

    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Category Category { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            Category = _db.Category.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {

            if (ModelState.IsValid)
            {
                var CategoryFromDb = _db.Category.Find(Category.Id);
                if (CategoryFromDb is not null)
                {
                    _db.Category.Remove(CategoryFromDb);
                    await _db.SaveChangesAsync();
                    return RedirectToPage("Index");
                }
            }
            return Page();
        }
    }
}
