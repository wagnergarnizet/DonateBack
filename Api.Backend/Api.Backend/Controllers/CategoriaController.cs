using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.Backend.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Backend.Models;
using Api.Backend.Data.Dtos.Categoria;

namespace Api.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public CategoriaController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpPost]
        public IActionResult AdicionaCategoria([FromBody] CreateCategoriaDto categoriaDto)
        {
            Categoria categoria = _mapper.Map<Categoria>(categoriaDto);
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaCategoriasPorId), new { Id = categoria.Id }, categoria);
        }

        [HttpGet]
        public IEnumerable<Categoria> RecuperaCategorias([FromQuery] string nomeDoFilme)
        {
            return _context.Categorias;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaCategoriasPorId(int id)
        {
            Categoria categoria = _context.Categorias.FirstOrDefault(categoria => categoria.Id == id);
            if (categoria != null)
            {
                ReadCategoriaDto categoriaDto = _mapper.Map<ReadCategoriaDto>(categoria);
                return Ok(categoriaDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCategoria(int id, [FromBody] UpdateCategoriaDto categoriaDto)
        {
            Categoria categoria = _context.Categorias.FirstOrDefault(categoria => categoria.Id == id);
            if (categoria == null)
            {
                return NotFound();
            }
            _mapper.Map(categoriaDto, categoria);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaCategoria(int id)
        {
            Categoria categoria = _context.Categorias.FirstOrDefault(categoria => categoria.Id == id);
            if (categoria == null)
            {
                return NotFound();
            }
            _context.Remove(categoria);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
