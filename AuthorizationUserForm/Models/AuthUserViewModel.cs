using AuthorizationUserForm.Domain.Enum;

namespace AuthorizationUserForm.Models;

public class AuthUserViewModel
{
    public long Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; }
}