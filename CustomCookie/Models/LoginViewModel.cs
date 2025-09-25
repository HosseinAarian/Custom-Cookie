using System.ComponentModel;

namespace CustomCookie.Models;

public class LoginViewModel
{
    public string UserName { get; set; } = "";
    [PasswordPropertyText]
    public string Password { get; set; } = "";
    public bool RememberMe { get; set; }
}
