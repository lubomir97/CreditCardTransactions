using Core.Interfaces.Repositories;
using Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebApi.ViewModels;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientAccountController : ControllerBase
    {
        private readonly IClientRepository _context;

        public ClientAccountController(IClientRepository context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetClients()
        {
            var clients = await _context.GetAsync();
            return Ok(clients);
        }


        [HttpPost]
        public async Task<IActionResult> AddClient(ClientToAddViewModel newClient)
        {
            var client = new Client {   FirstName = newClient.FirstName, 
                                        LastName = newClient.LastName,
                                        BirthDate = newClient.BirthDate,
                                        Email = newClient.Email,
                                        PhoneNumber = newClient.PhoneNumber,
                                        Adress = newClient.Adress,
                                        CreatedOn = DateTime.Now,
                                        Status = Core.Enums.Status.Active};

            await _context.InsertAsync(client);
            await _context.SaveChangesAsync();
            return Ok(client);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            var clients = await _context.GetAsync();
            var client = clients.Where(x => x.Id == id).Single();
            _context.Delete(client);
            await _context.SaveChangesAsync();
            return Ok($"{nameof(Client)} has been deleted");
        }
    }
}
