using System;
using System.Collections.Generic;

namespace PaarisAPI.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? CurrencyType { get; set; }

    public double? OldPrice { get; set; }

    public double CurrentPrice { get; set; }

    public string? ShortDesc { get; set; }

    public string? Sku { get; set; }

    public string? Vendor { get; set; }

    public bool? InStock { get; set; }

    public string? LongDesc { get; set; }

    public string? AddInfo { get; set; }

    public DateTime? PublishedAt { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? Slug { get; set; }

    public string? Locale { get; set; }

    public int? Category { get; set; }

    public bool? BestSelling { get; set; }

    public bool? OutOfStock { get; set; }

    public bool? Hot { get; set; }

    public bool? OnSell { get; set; }

    public bool? BestSellingProducts { get; set; }

    public bool? NewArrivalProducts { get; set; }

    public bool? NewArrival { get; set; }

    public byte[]? ImageUrl { get; set; }
}
