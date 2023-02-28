using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CapenexisLearners2023.Models;

namespace CapenexisLearners2023.Data
{
    public class CapenexisLearners2023Context : DbContext
    {
        public CapenexisLearners2023Context (DbContextOptions<CapenexisLearners2023Context> options)
            : base(options)
        {
        }

        public DbSet<CapenexisLearners2023.Models.Courses> Courses { get; set; } = default!;

        public DbSet<CapenexisLearners2023.Models.Learners> Learners { get; set; } = default!;

        public DbSet<CapenexisLearners2023.Models.Facilitators> Facilitators { get; set; } = default!;
    }
}
