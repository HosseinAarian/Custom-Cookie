namespace CustomCookie.Entities;

public class User
{
	public Guid Id { get; set; }
	public string UserName { get; set; }
	public string Password { get; set; }
	public bool IsActive { get; set; }
	public DateTime CreatedDate { get; set; }
}
