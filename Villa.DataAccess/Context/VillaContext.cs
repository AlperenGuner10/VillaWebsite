using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Entity.Entities;

namespace Villa.DataAccess.Context
{
	public class VillaContext : DbContext
	{
		public VillaContext(DbContextOptions options) : base(options) 
		{
			
		}
		public DbSet<Banner> Banners { get; set; }
		public DbSet<SubHeader> SubHeaders { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Counter> Counters { get; set; }
		public DbSet<Deal> Deals { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Message> Messages { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Quest> Quests { get; set; }
		public DbSet<Video> Videos { get; set; }
	}
}
