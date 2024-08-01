using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SalonApp.Core.Entities;
using SalonApp.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalonApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        private readonly IMapper _mapper;

        public ClientesController(IClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }

        // GET: api/Clientes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClienteDto>>> GetClientes()
        {
            var clientes = await _clienteService.GetAllClientesAsync();
            return Ok(_mapper.Map<IEnumerable<ClienteDto>>(clientes));
        }

        // GET: api/Clientes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClienteDto>> GetCliente(int id)
        {
            var cliente = await _clienteService.GetClienteByIdAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ClienteDto>(cliente));
        }

        // POST: api/Clientes
        [HttpPost]
        public async Task<ActionResult<ClienteDto>> PostCliente(ClienteDto clienteDto)
        {
            var cliente = _mapper.Map<Cliente>(clienteDto);
            var nuevoCliente = await _clienteService.CreateClienteAsync(cliente);
            var nuevoClienteDto = _mapper.Map<ClienteDto>(nuevoCliente);
            return CreatedAtAction(nameof(GetCliente), new { id = nuevoClienteDto.Id }, nuevoClienteDto);
        }

        // PUT: api/Clientes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCliente(int id, ClienteDto clienteDto)
        {
            if (id != clienteDto.Id)
            {
                return BadRequest();
            }

            var cliente = _mapper.Map<Cliente>(clienteDto);
            await _clienteService.UpdateClienteAsync(cliente);

            return NoContent();
        }

        // DELETE: api/Clientes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var cliente = await _clienteService.GetClienteByIdAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            await _clienteService.DeleteClienteAsync(id);
            return NoContent();
        }
    }
}