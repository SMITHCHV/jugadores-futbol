namespace jugadores_futbol.Models;

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();
}
