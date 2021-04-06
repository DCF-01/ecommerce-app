﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using semenarna_id2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace semenarna_id2.Data {
    public class ApplicationDbContext : IdentityDbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }
        public DbSet<TestProductModel> TestProduct { get; set; }
    }
}
