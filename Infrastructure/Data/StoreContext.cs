using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
  public class StoreContext : DbContext
  {
    public StoreContext()
    {
       
        DbPath="skinet.db";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite($"Data Source={DbPath}");



    public string DbPath { get; }
    public DbSet<Product> Products { get; set; }
  }
}