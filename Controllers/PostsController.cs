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

	[HttpPost]
	public async Post<ActionResult<Post>> PostPost(Post post)
	{
		_context.Posts.Add(Post);
		await _context.SaveChangesAsync();
		retur CretedAtAction(nameof(GetPosts), new { id = user.Id }, user);
	}
}