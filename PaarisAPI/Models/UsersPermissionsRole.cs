using System;
using System.Collections.Generic;

namespace PaarisAPI.Models;

public partial class UsersPermissionsRole
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Type { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }
}
