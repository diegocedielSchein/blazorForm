﻿using Microsoft.EntityFrameworkCore;

namespace BlazorUserApp.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) 
        {
            
        }
        public DbSet<Users> Users { get; set; }
    }
}
