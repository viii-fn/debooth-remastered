using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using debooth.Data;
using debooth.Models;

[Route("api/Controllers")]
[ApiController]
public class UserPostsController : ControllerBase
{
	private readonly AppDbContext _context;

	public UserPostsController(AppDbContext context)
	{
		_context = context;
	}

	[HttpGet]
	public async Task<ActionResult<IEnumerable<UserPost>>> GetUserPosts()
	{
		return await _context.UserPosts.ToListAsync();
	}

	[HttpPost]
	public async Task<ActionResult<UserPost>> PostUserPosts(UserPost post)
	{
		_context.UserPosts.Add(post);
		await _context.SaveChangesAsync();
		return CreatedAtAction(nameof(GetPosts), new { id = post.Id }, post);
	}
}