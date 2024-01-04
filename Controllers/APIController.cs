using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace helloworld_swagger_docker.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class APIController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetValue()
        {
            return "Hello World!";
        }

        /// <summary>
        /// Add numbers
        /// </summary>
        /// <remarks>
        /// Return the Sum of num1 and num2 
        /// </remarks>
        /// <param name="num1">number 1</param>
        /// <param name="num2">number 2</param>
        /// <returns>the sum</returns>
        [HttpGet]
        public ActionResult<int> Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
