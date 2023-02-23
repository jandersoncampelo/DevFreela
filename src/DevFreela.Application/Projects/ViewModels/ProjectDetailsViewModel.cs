namespace DevFreela.Application.Projects.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public ProjectDetailsViewModel(int id,
                                       string title,
                                       string description,
                                       decimal totalCost,
                                       DateTime startDate,
                                       DateTime endDate,
                                       string clientFullName,
                                       string freelancerFullName)
        {
            Id = id;
            Title = title;
            Description = description;
            TotalCost = totalCost;
            StartDate = startDate;
            EndDate = endDate;
            ClientFullName = clientFullName;
            FreelancerFullName = freelancerFullName;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public string ClientFullName { get; private set; }
        public string FreelancerFullName { get; private set; }
    }
}
