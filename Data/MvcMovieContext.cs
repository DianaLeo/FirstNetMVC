using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using first_aspnetcore_mvc.Models;

namespace first_aspnetcore_mvc.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<first_aspnetcore_mvc.Models.Movie> Movie { get; set; } = default!;
    }
}
