using Microsoft.AspNetCore.Mvc;
using HelpDeskAPI.Models;
using HelpDeskAPI.Data;

namespace HelpDeskAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ChamadosController : ControllerBase
{
	private readonly AppDbContext _context;

	public ChamadosController(AppDbContext context)
	{
		_context = context;
	}

	[HttpGet]
	public IActionResult Get()
	{
		return Ok(_context.Chamados.ToList());
	}

	[HttpGet("{id}")]
	public IActionResult GetById(int id)
	{
		var chamado = _context.Chamados.Find(id);

		if (chamado == null)
			return NotFound();

		return Ok(chamado);
	}

	[HttpPost]
	public IActionResult Post([FromBody] Chamado chamado)
	{
		_context.Chamados.Add(chamado);
		_context.SaveChanges();

		return Ok(chamado);
	}

	[HttpPut("{id}")]
	public IActionResult Put(int id, [FromBody] Chamado chamadoAtualizado)
	{
		var chamado = _context.Chamados.Find(id);

		if (chamado == null)
			return NotFound();

		chamado.Titulo = chamadoAtualizado.Titulo;
		chamado.Descricao = chamadoAtualizado.Descricao;
		chamado.Status = chamadoAtualizado.Status;

		_context.SaveChanges();

		return Ok(chamado);
	}

	[HttpDelete("{id}")]
	public IActionResult Delete(int id)
	{
		var chamado = _context.Chamados.Find(id);

		if (chamado == null)
			return NotFound();

		_context.Chamados.Remove(chamado);
		_context.SaveChanges();

		return Ok("Removido com sucesso");
	}
}