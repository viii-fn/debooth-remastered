using System.ComponentModel.DataAnnotations;

namespace debooth.Models;

public class Post
{
	public int Id { get; set; }
	[Required]
	public string Content { get; set; } = string.Empty;
	public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}