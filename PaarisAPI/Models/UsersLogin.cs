using System;
using System.Collections.Generic;

namespace PaarisAPI.Models;

public partial class UsersLogin
{
    public int Userid { get; set; }

    public string? Name { get; set; }

    public string EmailId { get; set; } = null!;

    public string? Password { get; set; }

    public string? Role { get; set; }
}
