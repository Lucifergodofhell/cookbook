using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Webproject.Models.Tweet;

namespace Webproject.Models
{
    public class WebprojectContext : DbContext
    {
        public WebprojectContext (DbContextOptions<WebprojectContext> options)
            : base(options)
        {
        }

        public DbSet<Webproject.Models.Tweet.Post> Post { get; set; }
    }
}
