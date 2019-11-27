using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IS7024IndividualAssignment.Pages
{
    public class AutoCompleteCraftsModel : PageModel
    {
        [BindProperty]
        private string Term { get; set; }
        private IList<string> craftNames = new List<string>();
        public JsonResult OnGet()
        {
            Term = HttpContext.Request.Query["term"];

            AddCrafts("Quiling");
            AddCrafts("Paper Cutting");
            AddCrafts("Paper Folding");
            AddCrafts("Paper Model");
            AddCrafts("Painting");
            AddCrafts("Paper Layering");
            AddCrafts("Crafting flowers");
            AddCrafts("Crafting Cards");
            AddCrafts("Quiling  Card");
            

            return new JsonResult(craftNames);
        }

        private void AddCrafts(string craftName)
        {
            string lowername = craftName.ToLower();
            string lowerterm = Term.ToLower();
            if (lowername.Contains(lowerterm))
            {
                craftNames.Add(craftName);
            }
        }
    }
}