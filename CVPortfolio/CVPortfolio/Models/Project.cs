
namespace CVPortfolio.Models
{
    public class Project
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string TechStack { get; set; } = string.Empty;
        public string GitHubUrl { get; set; } = string.Empty;
        public string? LiveUrl { get; set; }
        public string? ImageUrl { get; set; }

    }
}
