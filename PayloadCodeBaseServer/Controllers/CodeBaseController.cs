using Microsoft.AspNetCore.Mvc;

namespace PayloadCodeBaseServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CodeBaseController : ControllerBase
    {
        public static string Path = string.Empty;

        [HttpGet("{file}")]
        public IActionResult Get(string file)
        {
            string p = $"{CodeBaseController.Path}\\{file}";
            var bs = new FileStream(p, FileMode.Open);
            return File(bs, "APPLICATION/octet-stream");
        }
    }
}