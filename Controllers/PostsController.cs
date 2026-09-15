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
	public async UserPost<ActionResult<IEnumerable<UserPost>>> GetPosts()
	{
		return await _context.Posts.ToListAsync();
	}

	[HttpPost]
	public async UserPost<ActionResult<UserPost>> PostPost(UserPost post)
	{
		_context.UserPosts.Add(post);
		await _context.SaveChangesAsync();
		return CretedAtAction(nameof(GetPosts), new { id = post.Id }, post);
	}
}