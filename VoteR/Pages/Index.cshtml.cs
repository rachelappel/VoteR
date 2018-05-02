using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using VoteR.Models;

namespace VoteR.Pages
{
    public class IndexModel : PageModel
    {
        public List<Item> items = new ItemsList();
        public void OnGet()
        {

        }
    }
}
