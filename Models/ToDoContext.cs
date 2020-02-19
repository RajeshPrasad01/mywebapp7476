using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myWebApp7475.Models;
using Microsoft.EntityFrameworkCore;

namespace myWebApp7475.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
        : base(options)
        {
        }

        public DbSet<ToDoItem> TodoItems { get; set; }
    }
}
