using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnet.Controllers
{
    [Route("/")]
    public class HelloWorldController : Controller
    {
      [HttpGet]
      public Task<HelloWorldResponse> Get()
      {
        return Task.FromResult(new HelloWorldResponse());
      }    
    }
}
