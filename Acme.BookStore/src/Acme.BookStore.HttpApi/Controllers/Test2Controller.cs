using Acme.BookStore.Localization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.Controllers;

/* Inherit your controllers from this class.
 */
 [Route("api/[controller]")]
public class Test2Controller : AbpControllerBase
{

    [HttpGet("")]
    public IActionResult Index()
    {
        return Content("Hello World!");
    }
}
