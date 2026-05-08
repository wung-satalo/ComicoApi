using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ComicoApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ComicoApi.Data;
using ComicoApi.Models;

namespace ComicoApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BannersController : ControllerBase
{
    private readonly AppDbContext _db;

    public BannersController(AppDbContext db)
    {
        _db = db;
    }

    // GET /api/banners
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var banners = await _db.Banners
            .Select(b => b.ImageUrl)
            .ToListAsync();
        return Ok(banners);
    }

    // POST /api/banners
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Banner banner)
    {
        _db.Banners.Add(banner);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetAll), new { id = banner.Id }, banner);
    }

    // DELETE /api/banners/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var banner = await _db.Banners.FindAsync(id);
        if (banner == null) return NotFound();
        _db.Banners.Remove(banner);
        await _db.SaveChangesAsync();
        return NoContent();
    }
}