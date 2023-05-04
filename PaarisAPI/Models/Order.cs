using System;
using System.Collections.Generic;

namespace PaarisAPI.Models;

public partial class Order
{
    public int Id { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public int? Productid { get; set; }

    public DateTime? PublishedAt { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Email { get; set; }

    public string? Fullname { get; set; }

    public string? Payment { get; set; }

    public string? Name { get; set; }

    public string? Phone { get; set; }

    public string? Status { get; set; }

    public float? TotalPrice { get; set; }

    public int? UsersPermissionsUser { get; set; }
}
