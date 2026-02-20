namespace CVPortfolio.Models.ViewModel
{
    public class PortfolioViewModel
    {
        public Profile? Profile { get; set; }
        public List<Skill>? Skills { get; set; }
        public List<Project>? Projects { get; set; }
        public List<Education>? Education { get; set; }
        public List<Experience>? Experiences { get; set; }
    }
}
