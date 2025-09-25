using System.ComponentModel.DataAnnotations;

namespace CustomCookie.Models;

public class RegisterViewModel
{
    public string Username { get; set; }

    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Compare(nameof(Password))]
    public string ConfirmPassword { get; set; }
}
