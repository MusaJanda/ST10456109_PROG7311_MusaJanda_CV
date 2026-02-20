using System.Data;


namespace CVPortfolio.Models
{
    public class Profile
    {
        public string FullName { get; set; } = "Musa Janda";
        public string Title { get; set; } = "Final-Year IT Student · Aspiring Software Developer and Penetration Tester";
        public string AboutMe { get; set; } = "I'm a passionate final-year IT student at IIE Emeris with a keen interest in full-stack development and ethical hacking. I love building practical solutions to real-world problems and am constantly exploring new technologies. When I'm not coding, you'll find me contributing to open-source projects or tutoring junior students.";
        public string Email { get; set; } = "JandaMusa17@gmail.com";
        public string LinkedInUrl { get; set; } = "https://linkedin.com/in/musa-janda-36b22028a";
        public string GitHubUrl { get; set; } = "https://github.com/MusaJanda/ST10456109_PROG7311_MusaJanda_CV.git";
        public string ProfilePhoto { get; set; } = "/Images/profile.jpg";
        public string DownloadableCV { get; set; } = "wwwroot/Files/MusaJanda_CV.pdf";

    }
}
