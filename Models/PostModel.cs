namespace debooth.Models;

public class PostModel
{
	public int Id { get; set; }
	[Required]
	public string Content { get; set; } = string.Empty;
	public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}