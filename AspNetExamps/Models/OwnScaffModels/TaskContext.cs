using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetExamps.Models.OwnScaffModels
{
    public class TaskContext : DbContext
    {
        public TaskContext() : base("TaskConnection")
        {

        }

        public DbSet<Task> Tasks { get; set; }
    }
}