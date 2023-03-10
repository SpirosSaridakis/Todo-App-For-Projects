using Project_Todo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Todo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("Projects")
        {
        }
        DbSet<Project> Projects { get; set; }
        DbSet<Models.Task> Tasks { get; set; }

    }
}
