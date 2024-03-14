using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NC_24.Models;

namespace NC_24.Models
{
    public class NC_24Context : DbContext
    {
        public NC_24Context (DbContextOptions<NC_24Context> options)
            : base(options)
        {
        }

        public DbSet<NC_24.Models.Group> Group { get; set; } = default!;
        public DbSet<NC_24.Models.Student> Student { get; set; } = default!;
        public DbSet<NC_24.Models.Field> Field { get; set; } = default!;
        public DbSet<NC_24.Models.Course> Course { get; set; } = default!;
    }
}
