using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCWebApp.Models;

/*
 * This cretaes a DbSet<Event> property that represents Events in the database
 */
namespace MVCWebApp.Data
{
    public class MVCWebAppContext : DbContext
    {
        public MVCWebAppContext (DbContextOptions<MVCWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MVCWebApp.Models.Events>? Events { get; set; }
    }
}
