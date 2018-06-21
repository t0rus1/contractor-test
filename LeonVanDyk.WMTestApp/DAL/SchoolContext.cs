using LeonVanDyk.WMTestApp.Models;
using System.Data.Entity;

namespace LeonVanDyk.WMTestApp.DAL
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}