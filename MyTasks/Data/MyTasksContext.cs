using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyTasks.Models;

namespace MyTasks.Data
{
    public class MyTasksContext : DbContext
    {
        public MyTasksContext (DbContextOptions<MyTasksContext> options)
            : base(options)
        {
        }

        public DbSet<MyTasks.Models.ToDo>? ToDo { get; set; }
    }
}
