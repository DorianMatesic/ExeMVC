namespace ProjectsMVC.Models;

public class ProjectsService : IProjectsService
    {
        private readonly ApplicationDbContext _dbContext;

        public ProjectsService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return _dbContext.Projects.ToList();
        }

        public Project GetProjectById(int id)
        {
            return _dbContext.Projects.FirstOrDefault(p => p.Id == id);
        }

        public void AddProject(Project project)
        {
            _dbContext.Projects.Add(project);
            _dbContext.SaveChanges();
        }

        public void UpdateProject(Project project)
        {
            _dbContext.Projects.Update(project);
            _dbContext.SaveChanges();
        }

        public void DeleteProject(int id)
        {
            var projectToDelete = _dbContext.Projects.FirstOrDefault(p => p.Id == id);
            if (projectToDelete != null)
            {
                _dbContext.Projects.Remove(projectToDelete);
                _dbContext.SaveChanges();
            }
        }
    }