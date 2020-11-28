using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BEL_MVC_APP.Models;
namespace BEL_MVC_APP.DAL
{
    public class BELMVCDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public BELMVCDBContext() : base()
        {

        }

        public BELMVCDBContext(DbContextOptions options) : base(options)
        {

        }
    }
}
