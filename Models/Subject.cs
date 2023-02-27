namespace ProjectsMVC.Models;

public class Subject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Departement { get; set; }
    public int Semester { get; set; }
    public string Description { get; set; }

    public List<Project> Projects { get; set; }
}