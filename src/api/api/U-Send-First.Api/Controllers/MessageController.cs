using Microsoft.AspNetCore.Mvc;
using U_Send_First.Data.Services.Abstractions;

namespace U_Send_First.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService service;

        public MessageController(IMessageService service)
        {
            this.service = service;
        }

        [HttpGet("list/{id}")]
        public IActionResult GetUserMessages([FromRoute] Guid id)
        {
            var result = service.GetMessageByUserId(id);
            if (result is null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("info/{id}")]
        public IActionResult InfoForUser([FromRoute] Guid id)
        {
            var result = service.InfoForUser(id);
            if (result is null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("get/{id}")]
        public IActionResult GetMessageById([FromRoute] Guid id)
        {
            var result = service.GetMessageById(id);
            if (result is null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost("read/{id}")]
        public IActionResult ReadMessage([FromRoute] Guid id)
        {
            var result = service.ReadMessage(id);
            if (result)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
    
}