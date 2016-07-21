using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace DataGridTimeScheduler.Models
{
    public class TimeSchedulerContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TimeSchedule> TimeSchedulers { get; set; }
        public DbSet<TimeScheduleType> TimeShedulerTypes { get; set; }
        public DbSet<Message> Messages { get; set; }

        public TimeSchedulerContext()
            : base("name=")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            //base.OnModelCreating(modelBuilder);
        }
    }
}