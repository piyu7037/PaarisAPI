using System;
using System.Collections.Generic;

namespace PaarisAPI.Models;

public partial class ProductsOrder
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }
}
