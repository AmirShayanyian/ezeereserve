using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyReserve.Controllers
{
    [Route("controller")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpPost]
        public string Test(int test)
        {
            var s = 0;
            for (int i = 1;i<= test;i++)
            {
                if(test % i == 0)
                {
                    s++;
                }
            }
            if (s != 2)
            {
                return "This is not an Prime Number!";
            } else
            {
                return "Hooray!";
            }
        }
    }
}
