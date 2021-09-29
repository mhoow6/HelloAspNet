using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPITutorial.Controllers
{
    public class HelloMessage
    {
        public string Message { get; set; }
    }

    // 다른 애들에서 Startup에서 라우팅한 것을 여기서 한다.
    // https://localhost:44320/api/values
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public List<HelloMessage> Get()
        {
            List<HelloMessage> messages = new List<HelloMessage>();
            messages.Add(new HelloMessage() { Message = "Hello Web API 1!" });
            messages.Add(new HelloMessage() { Message = "Hello Web API 2!" });
            messages.Add(new HelloMessage() { Message = "Hello Web API 3!" });

            return messages;
        }
    }
}
