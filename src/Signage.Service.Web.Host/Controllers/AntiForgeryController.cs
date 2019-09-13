using Microsoft.AspNetCore.Antiforgery;
using Signage.Service.Controllers;

namespace Signage.Service.Web.Host.Controllers
{
    public class AntiForgeryController : ServiceControllerBase
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
