﻿using Microsoft.AspNetCore.Mvc;
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
            if(result is null)
            {
                return NotFound();
            }
            return Ok(result);
        }

    }
}