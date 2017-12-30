using System;
using Microsoft.EntityFrameworkCore;

namespace Chorch.Models
{
	public class ChorchDbContext : DbContext
	{
		public ChorchDbContext(DbContextOptions<ChorchDbContext> options) : base(options)
		{
		}

		public DbSet<Member> Member { get; set; }

		//protected override void OnModelCreating(ModelBuilder modelBuilder)
		//{
		//	base.OnModelCreating(modelBuilder);
		//}
	}
}
