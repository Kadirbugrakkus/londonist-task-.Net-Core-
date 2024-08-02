using CrmApp.Core.Services;
using CrmApp.Models.Requests;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace CrmApp.App.Controllers.api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactApiController : ControllerBase
    {
        private readonly ContactService _contactService;

        public ContactApiController(ContactService  contactService) 
        {
            _contactService = contactService;
        }

        // POST: /api/Contact/Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Store([FromBody] ContactRequest request)
        {
            try
            {
                var contact = await _contactService.CreateContactAsync(request);
                return Ok(contact);
            }
            catch (ValidationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}