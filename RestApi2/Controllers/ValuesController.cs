using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet(Name = "GetValues")]
        public IEnumerable<string> Get()
        {
            return ["RestApi2_Value1", "RestApi2_Value2"];
        }
    }
}
