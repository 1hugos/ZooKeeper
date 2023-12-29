namespace ZooKeeper.Models;

public class Caretaker
{
	public int CaretakerId { get; set; }
	public string Name { get; set; }

	// Navigation properties
	public List<Animal> Animals { get; set; }
}
