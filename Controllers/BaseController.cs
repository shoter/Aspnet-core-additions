using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Aspnet.Additions.Actions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Aspnet.Additions.Controllers
{
    public class BaseController : Controller
    {
        protected ValidationFailedResult ValidationFailedResult(ModelStateDictionary modelState)
        {
            return new ValidationFailedResult(modelState);
        }

        protected IActionResult ValidationFailed()
        {
            return BadRequest(ValidationFailedResult(ModelState));
        }
     
    }
}
