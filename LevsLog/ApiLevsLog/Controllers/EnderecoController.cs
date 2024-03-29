﻿using ApiLevsLog.Data;
using ApiLevsLog.Mapper;
using ApiLevsLog.Models;
using ApiLevsLog.Models.Dtos.EnderecoDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiLevsLog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public EnderecoController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetEnderecos()
        {
            List<Enderecos> enderecos = await _dbContext.Enderecos.Include("Cliente").ToListAsync();

            if (enderecos.Count == 0)
            {
                return NotFound();
            }

            var enderecosDto = EnderecoProfile.EnderecosToReadEnderecos(enderecos);

            return Ok(enderecosDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEndereco(int id)
        {
            Enderecos endereco = await _dbContext.Enderecos.Include("Cliente").FirstOrDefaultAsync(e => e.Id == id);

            if (endereco == null)
            {
                return NotFound();
            }

            var enderecoDto = EnderecoProfile.ReadEnderecoById(endereco);

            return Ok(enderecoDto);
        }

        [HttpPost]
        public async Task<IActionResult> AddEndereco([FromBody] Enderecos endereco)
        {
            await _dbContext.Enderecos.AddAsync(endereco);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEndereco), new { id = endereco.Id }, endereco);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpEndereco(int id, [FromBody] UpdateEndereco enderecoDto)
        {
            var endereco = await _dbContext.Enderecos.FirstOrDefaultAsync(x => x.Id == id);

            if (endereco == null)
            {
                return NotFound();
            }

            endereco = EnderecoProfile.UpdateEndereco(enderecoDto, endereco);

            await _dbContext.SaveChangesAsync();

            var enderecoReadDto = EnderecoProfile.ReadEnderecoById(endereco);

            return Ok(enderecoReadDto);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarEndereco(int id)
        {
            Enderecos endereco = await _dbContext.Enderecos.FirstOrDefaultAsync(x => x.Id == id);

            if (endereco == null)
            {
                return NotFound();
            }

            _dbContext.Remove(endereco);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
