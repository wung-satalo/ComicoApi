using Microsoft.EntityFrameworkCore;
using ComicoApi.Data;
using ComicoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ComicsController : ControllerBase
{
    private readonly AppDbContext _db;

    public ComicsController(AppDbContext db)
    {
        _db = db;
    }

    // GET /api/comics
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var comics = await _db.Comics
            .Include(c => c.Chapters.OrderBy(ch => ch.Id))
            .ToListAsync();
        return Ok(comics);
    }

    // GET /api/comics/search?q=one
    [HttpGet("search")]
    public async Task<IActionResult> Search([FromQuery] string q)
    {
        if (string.IsNullOrEmpty(q) || q.Length < 3)
            return Ok(new List<Comic>());

        var result = await _db.Comics
            .Include(c => c.Chapters.OrderBy(ch => ch.Id))
            .Where(c => c.Name.Contains(q) || c.Category.Contains(q))
            .ToListAsync();

        return Ok(result);
    }

    // POST /api/comics
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Comic comic)
    {
        _db.Comics.Add(comic);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetAll), new { id = comic.Id }, comic);
    }

    // DELETE /api/comics/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var comic = await _db.Comics.FindAsync(id);
        if (comic == null) return NotFound();
        _db.Comics.Remove(comic);
        await _db.SaveChangesAsync();
        return NoContent();
    }
}