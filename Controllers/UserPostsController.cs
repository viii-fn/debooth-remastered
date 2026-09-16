using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using debooth.Data;
using debooth.Models;

[Route("api/[controller]")]
[ApiController]
public class UserPostsController : ControllerBase
{
	private readonly AppDbContext _context;

	public UserPostsController(AppDbContext context)
	{
		_context = context;
	}

	[HttpGet("faah")]
	public IActionResult Test()
	{
		return Ok("Your Sqlite is broken dawg");
	}


	[HttpGet]
	public async Task<ActionResult<IEnumerable<UserPost>>> GetAll()
	{
		return await _context.UserPosts.ToListAsync();
	}

	[HttpGet("{id}")]
	public async Task<ActionResult<UserPost>> GetById(int id)
	{
		var post = await _context.UserPosts.FindAsync(id);
		if (post == null)
		{
			return NotFound();
		}

		return post;
	}

	[HttpPost]
	public async Task<ActionResult<UserPost>> Create(UserPost post)
	{
		_context.UserPosts.Add(post);
		await _context.SaveChangesAsync();
		return CreatedAtAction(nameof(GetById), new { id = post.Id }, post);
	}
}