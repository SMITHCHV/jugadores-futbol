namespace jugadores_futbol.Models;

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Age { get; set; }
    public string Position { get; set; } = null!;
    public ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
}
