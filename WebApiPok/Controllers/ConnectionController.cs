using Microsoft.AspNetCore.Mvc;

namespace WebApiPok.Controllers
{
    [Route("conn/")]
    [ApiController]
    public class ConnectionController : ControllerBase
    {
        /// <summary>
        /// https://localhost:44342/conn/Authenticate?email=user&password=test
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password">.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Authenticate")]
        public ActionResult<bool> Authenticate(string email, string password)
        {
            return (email == "user" && password == "test");
        }
    }
}
