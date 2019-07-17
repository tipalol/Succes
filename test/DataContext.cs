using System;
using System.Data.Entity;

namespace test
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {
        }

        public DbSet<Somethings> Somethings { get; set; }
    }
}
