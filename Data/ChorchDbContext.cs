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

		public DbSet<Member> Members { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			//modelBuilder.Entity<Member>().ToTable("Member");

		}

		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//=> optionsBuilder.UseMySql("ChorchConnection");
	}
}
