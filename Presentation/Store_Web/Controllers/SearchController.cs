using Microsoft.AspNetCore.Mvc;
using Store;
namespace Store_Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly IBookRepository bookRepository;
        public SearchController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;            
        }
        public IActionResult Index(string query)
        {
            var books = bookRepository.GetAllByTitle(query);
            return View(books);
        }
    }
}
