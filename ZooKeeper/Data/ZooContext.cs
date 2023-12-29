using Microsoft.EntityFrameworkCore;
using ZooKeeper.Models;

namespace ZooKeeper.Data;

public class ZooContext : DbContext
{
	public DbSet<Animal> Animals { get; set; }
	public DbSet<Species> Species { get; set; }
	public DbSet<Caretaker> Caretakers { get; set; }

	public ZooContext(DbContextOptions<ZooContext> options) : base(options)
	{
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		// Dodaj ewentualne konfiguracje modelu, np. relacje między tabelami
	}
}
