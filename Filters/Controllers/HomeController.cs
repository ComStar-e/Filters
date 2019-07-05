using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Filters.Infrastructure;


namespace Filters.Controllers
{
    public class HomeController :Controller
    {
        [HttpsOnly]
        public IActionResult Index() => View("Message", "This HTTPS Message Only");
        
        
    }
}
