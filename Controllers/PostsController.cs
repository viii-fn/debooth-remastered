using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using debooth.Models;

[Route("api/Controllers")]
[ApiController]
public class PostsController : ControllerBase
{
	private readonly AppDbContext _context;
}