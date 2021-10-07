using Microsoft.EntityFrameworkCore;
using Demo.Models;

namespace Demo.Data
{
    public class SinhVienContext : DbContext
    {
        public SinhVienContext(DbContextOptions<SinhVienContext> options)
            : base(options) { }
        public DbSet<SinhVien> SinhVien { get; set; }
    }
}
