namespace ZooKeeper.Models;

public class Animal
{
	public int AnimalId { get; set; }
	public string Name { get; set; }
	public DateTime Birthdate { get; set; }
	public int SpeciesId { get; set; }

	// Navigation property
	public Species Species { get; set; }
}
