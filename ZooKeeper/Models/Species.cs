namespace ZooKeeper.Models;

public class Species
{
	public int SpeciesId { get; set; }
	public string Name { get; set; }

	// Navigation properties
	public List<Animal> Animals { get; set; }
}
