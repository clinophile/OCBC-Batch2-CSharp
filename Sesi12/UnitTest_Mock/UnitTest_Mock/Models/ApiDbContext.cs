﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UnitTest_Mock.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }

}

