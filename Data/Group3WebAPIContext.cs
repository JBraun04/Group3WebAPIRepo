using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Group3WebAPI.Models;

namespace Group3WebAPI.Data
{
    public class Group3WebAPIContext : DbContext
    {
        public Group3WebAPIContext (DbContextOptions<Group3WebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Group3WebAPI.Models.TeamMember> TeamMember { get; set; } = default!;
        public DbSet<Group3WebAPI.Models.Breakfast> Breakfast { get; set; } = default!;
        public DbSet<Group3WebAPI.Models.Hobby> Hobby { get; set; } = default!;

        public DbSet<Group3WebAPI.Models.Movie> Movie { get; set; } = default!;

        public DbSet<Group3WebAPI.Models.TravelDestination> TravelDestination { get; set; } = default!;
    }
}
