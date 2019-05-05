using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Booklist
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _dbContext;
        public IEnumerable<Book> Books { get; set; }

        public IndexModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            //dependency injection is done 
        }
        public void OnGet()
        {
         
        }
    }
}