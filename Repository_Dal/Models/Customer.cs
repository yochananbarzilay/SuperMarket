﻿using System;
using System.Collections.Generic;

namespace Repository_Dal.Models;

public partial class Customer
{
    public int Code { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Shopping> Shoppings { get; set; } = new List<Shopping>();
}
