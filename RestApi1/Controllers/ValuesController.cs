using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet(Name = "GetValues")]
        public IEnumerable<string> Get()
        {
            return ["RestApi1_Value1", "RestApi1_Value2"];
        }
    }
}
