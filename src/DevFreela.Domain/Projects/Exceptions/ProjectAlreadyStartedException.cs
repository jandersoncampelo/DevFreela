namespace DevFreela.Domain.Projects;

public class ProjectAlreadyStartedException : Exception
{
    public ProjectAlreadyStartedException() : base("This project has already started.")
    {
    }
}
