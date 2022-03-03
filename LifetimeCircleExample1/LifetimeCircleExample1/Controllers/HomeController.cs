using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifetimeCircleExample1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly RandomGenerator randomGenerator1;
        private readonly RandomGenerator randomGenerator2;

        private readonly GuidGenerator guidGenerator1;
        private readonly GuidGenerator guidGenerator2;

        public HomeController(RandomGenerator randomGenerator1, RandomGenerator randomGenerator2,
                              GuidGenerator guidGenerator1, GuidGenerator guidGenerator2
                              )
        {
            this.randomGenerator1 = randomGenerator1;
            this.randomGenerator2 = randomGenerator2;

             this.guidGenerator1 = guidGenerator1;
             this.guidGenerator2 = guidGenerator2;
        }

        [HttpGet]
        public IActionResult Get_Random()
        {
            int number1 = randomGenerator1.Number;//78888
            int number2 = randomGenerator2.Number;//78888

            TestModel t1 = new TestModel(number1, number2);

            return Ok(t1);
        }

        [HttpGet]
        public IActionResult Get_Guid()
        {
            string guid1 = guidGenerator1.GUID;
            string guid2 = guidGenerator2.GUID;

            TestModel t1 = new TestModel(guid1, guid2);

            return Ok(t1);
        }
    }
}
