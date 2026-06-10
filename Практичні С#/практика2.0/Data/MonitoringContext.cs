using Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class MonitoringContext : DbContext
    {
        public DbSet<User> Users => Set<User>();


        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Specialization> Specializations => Set<Specialization>();
        public DbSet<SpecializationCategory> SpecializationCategories => Set<SpecializationCategory>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<ServiceCategory> ServiceCategories => Set<ServiceCategory>();
        public DbSet<Service> Services => Set<Service>();
        public DbSet<ServiceDependency> ServiceDependencies => Set<ServiceDependency>();
        public DbSet<Trigger> Triggers => Set<Trigger>();
        public DbSet<MonitoringCheck> MonitoringChecks => Set<MonitoringCheck>();
        public DbSet<Incident> Incidents => Set<Incident>();
        public DbSet<IncidentSeverity> IncidentSeverities => Set<IncidentSeverity>();
        public DbSet<IncidentComment> IncidentComments => Set<IncidentComment>();
        public DbSet<MaintenanceWindow> MaintenanceWindows => Set<MaintenanceWindow>();
        public DbSet<AuditLog> AuditLogs => Set<AuditLog>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=.;Database=Practice2;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ServiceDependency>()
                .HasOne(sd => sd.Service)
                .WithMany(s => s.Dependencies)
                .HasForeignKey(sd => sd.ServiceId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ServiceDependency>()
                .HasOne(sd => sd.DependsOnService)
                .WithMany(s => s.DependentServices)
                .HasForeignKey(sd => sd.DependsOnServiceId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Specialization)
                .WithMany(s => s.Employees)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Service>()
                .HasOne(s => s.Category)
                .WithMany(c => c.Services)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Service>()
                .HasOne(s => s.ResponsibleEmployee)
                .WithMany(e => e.ResponsibleServices)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Incident>()
                .HasOne(i => i.Service)
                .WithMany(s => s.Incidents)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Incident>()
                .HasOne(i => i.Severity)
                .WithMany(s => s.Incidents)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Incident>()
                .HasOne(i => i.AssignedToEmployee)
                .WithMany(e => e.AssignedIncidents)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Incident>()
                .HasOne(i => i.TriggeredByTrigger)
                .WithMany(t => t.TriggeredIncidents)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<MaintenanceWindow>()
                .HasOne(m => m.Service)
                .WithMany(s => s.MaintenanceWindows)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MaintenanceWindow>()
                .HasOne(m => m.ScheduledByEmployee)
                .WithMany(e => e.ScheduledMaintenances)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<IncidentComment>()
                .HasOne(c => c.Employee)
                .WithMany(e => e.Comments)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Trigger>()
                .HasOne(t => t.IncidentSeverity)
                .WithMany(s => s.Triggers)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AuditLog>()
                .HasOne(a => a.Employee)
                .WithMany()
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Login)
                .IsUnique();

            modelBuilder.Entity<Incident>()
                .HasIndex(i => new { i.ServiceId, i.Status });

            modelBuilder.Entity<MaintenanceWindow>()
                .HasIndex(m => new { m.ServiceId, m.StartDateTime, m.EndDateTime });

            modelBuilder.Entity<AuditLog>()
                .HasIndex(a => new { a.EntityType, a.EntityId, a.Timestamp });

            modelBuilder.SeedMonitoringData();
        }
    }
}

