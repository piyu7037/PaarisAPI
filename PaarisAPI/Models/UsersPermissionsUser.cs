using System;
using System.Collections.Generic;

namespace PaarisAPI.Models;

public partial class UsersPermissionsUser
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Provider { get; set; }

    public string? Password { get; set; }

    public string? ResetPasswordToken { get; set; }

    public string? ConfirmationToken { get; set; }

    public bool? Confirmed { get; set; }

    public bool? Blocked { get; set; }

    public int? Role { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
