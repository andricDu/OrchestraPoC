using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace OrchestraPoc.Models 
{
    public class OrchestraDbContext : DbContext
    {
        public DbSet<Queue> Queues { get; set; }
        public DbSet<Job> Jobs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=orchestra.db");
        }

    }

    public class Queue { 
        public int QueueId { get; set; }
        public string Workflow { get; set; }
    }

    public class Job {
        public int JobId { get; set; }
        public string Input { get; set; }

        public int QueueId { get; set; }
        public Queue Queue { get; set;}
    }
}
