﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication14.Models
{
    public class ProductContext:DbContext
    {
        public DbSet<Product> MyProperty { get; set; }
    }
}