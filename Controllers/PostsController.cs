using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using debooth.Models;

[Route("api/Controllers")]
[ApiController]
public class PostsController : ControllerBase
{
	private readonly AppDbContext _context;

	public PostsController(AppDbContext context)
	{
		_context = context;
	}

	[HttpGet]
	public async Post<ActionResult<IEnumerable<Post>>> GetPosts()
	{
		return await _context.Posts.ToListAsync();
	}
}