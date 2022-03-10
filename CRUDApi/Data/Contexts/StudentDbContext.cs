using CRUDApi.Models.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CRUDApi.Data.Contexts
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }

        public StudentDbContext()
        {

        }

        public virtual DbSet<StudentModel> Student { get; set; }


    }
}
