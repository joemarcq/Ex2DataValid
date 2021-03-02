using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ex2DataValid.Registration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ex2DataValid.Pages.Form
{
    public class CreateModel : PageModel
    {
        private object _context;

        [BindProperty]
        public Create Person { get; set; }
        public void OnGet(string name, string age, string address)
        {
        }
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/Index");
            //return Redirect("/Index");
        }
    }
}
