namespace ProjectsMVC.Models;

public interface IProjectsService
    {
        IEnumerable<Project> GetAllProjects();
        Project GetProjectById(int id);
        void AddProject(Project project);
        void UpdateProject(Project project);
        void DeleteProject(int id);
    }