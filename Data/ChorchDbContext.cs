using System;
using Chorch.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Chorch.Data
{
	public class ChorchDbContext : DbContext
	{
		public ChorchDbContext(DbContextOptions<ChorchDbContext> options) : base(options)
		{
		}

		public DbSet<Person> Persons { get; set; }
		public DbSet<Church> Church { get; set; }
		public DbSet<ChurchBD1> ChurchSuperGroup1 { get; set; }
		public DbSet<ChurchBD2> ChurchSuperGroup2 { get; set; }
		public DbSet<ChurchStatus> ChurchStatus { get; set; }
		public DbSet<Event> Event { get; set; }
		public DbSet<EventRegistration> EventRegistration { get; set; }
		public DbSet<Gender> Gender { get; set; }
		public DbSet<Group> Group { get; set; }
		public DbSet<MaritalStatus> MaritalStatus { get; set; }
		public DbSet<Organization> Organization { get; set; }
		public DbSet<OtherStatus> OtherStatus { get; set; }
		public DbSet<Status> Status { get; set; }
		public DbSet<Visitor> Visitor { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			//modelBuilder.Entity<Member>().ToTable("Member");

		}

		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//=> optionsBuilder.UseMySql("ChorchConnection");
	}
}
