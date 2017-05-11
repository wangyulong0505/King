using King.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace King.Web.Host.Controllers
{
    public class AntiForgeryController : KingControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}