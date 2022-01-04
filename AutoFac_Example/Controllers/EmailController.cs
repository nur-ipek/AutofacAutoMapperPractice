using AutoFac_Example.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoFac_Example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController:Controller
    {
        private readonly IMailService _mailService;
        public EmailController(IMailService mailService)
        {
            _mailService = mailService;
        }

        [HttpGet]
        public IActionResult GetEmailAddress()
        {
            var mails = _mailService.GetEmailAddress();

            return Ok(mails);
        }
    }
}
