namespace ProjectsMVC.Models;

public class Project {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public string Github { get; set; }
    public string Technologies { get; set; }
    public DateTime UploadDate { get; set; }

    public int SubjectId { get; set; }
    public Subject Subject { get; set; }

    public string? IdentityUserId { get; set; }
    public IdentityUser? IdentityUser { get; set; }
}