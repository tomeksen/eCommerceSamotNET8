﻿using eCommerceSamotNet8.Entities;
using Microsoft.EntityFrameworkCore;

namespace eCommerceSamotNet8.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
    }
}
