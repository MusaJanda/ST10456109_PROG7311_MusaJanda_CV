using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CVPortfolio.Models;
using CVPortfolio.Models.ViewModel;

namespace CVPortfolio.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var profile = new Profile
        {
            FullName = "Musa Janda", 
            Title = "Final-Year IT Student · Aspiring Software Developer and Penetration Tester",
            AboutMe = "I'm a passionate final-year IT student at IIE Emeris with a keen interest in full-stack development and ethical hacking. I love building practical solutions to real-world problems and am constantly exploring new technologies. When I'm not coding, you'll find me contributing to open-source projects or tutoring junior students.",
            Email = "st10456109@myemeris.edu.za",
            LinkedInUrl = "https://linkedin.com/in/musa-janda-36b22028a", 
            GitHubUrl = "https://github.com/MusaJanda/ST10456109_PROG7311_MusaJanda_CV.git", 
            DownloadableCV = "/files/MusaJanda_CV.pdf"
        };

        var skills = new List<Skill>
        {
            new Skill
            {
                Category = "Languages",
                Items = new List<string> { "C#", "Java", "Python", "JavaScript", "SQL", "MongoDB", "Kotlin" }
            },
            new Skill
            {
                Category = "Frameworks",
                Items = new List<string> { "ASP.NET MVC", "Entity Framework", "React", "Bootstrap" }
            },
            new Skill
            {
                Category = "Tools",
                Items = new List<string> { "Git", "VS Code", "Visual Studio", "SQL Server", "Postman", "Azure", "NetBeans" }
            },
            new Skill
            {
                Category = "Soft Skills",
                Items = new List<string> { "Team Collaboration", "Problem Solving", "Communication", "Time Management" }
            }
        };

        var projects = new List<Project>
        {
            new Project
            {
                Name = "Event Ease Online Shopping",
                Description = "A full-stack web application for managing event and vanue bookings. Users can create an event, book a vanue, and track progress.",
                TechStack = "ASP.NET MVC, Entity Framework, SQL Server, Bootstrap",
                GitHubUrl = "https://github.com/MusaJanda/ST10456109_CLDV6211_POE_PART3.git",
                LiveUrl = "https://taskmanager-demo.azurewebsites.net"
                
            },
            new Project
            {
                Name = "EasyKanban App",
                Description = "Developed a Kanban application for students to manage tasks with a TO-DO, DOING, and DONE using graphic user interface (GUI).",
                TechStack = "JOptionPane, Java Authentication, Apache NetBeans, Regex",
                GitHubUrl = "https://github.com/MusaJanda/ST10456109-PROG5121-POE.git"

            },
            new Project
            {
                Name = "CybersecurityChatBotGUI",
                Description = "Developed a Cybersecurity Education and Productivity Assistant.",
                TechStack = "WPF (Windows Presentation Foundation), Speech Synthesis, Audio Playback",
                GitHubUrl = "https://github.com/MusaJanda/PROG6221_ST104561096_PO3_PART3.git"

            }
        };

        var education = new List<Education>
        {
            new Education
            {
                Degree = "Bachelor of Computer and Information Science in Application Development.",
                Institution = "IIE Emeris",
                ExpectedGraduation = "2027",
                Modules = "Programming, Database, Cloud Development, Computer Networking, Information Systems, Programming Logic and Design, Mathematics"
            }
        };

        var experiences = new List<Experience>
        {
            new Experience
            {
                Title = "Cybersecurity Intern",
                Company = "Forage.",
                Period = "May 2024",
                Description = "Assisted in designing phishing email simulation using ASP.NET MVC. Interpreted phishing simulation results."
            },
            new Experience
            {
                Title = "Cybersecurity Intern",
                Company = "Forage.",
                Period = "November 2025",
                Description = "Performed an incident postmortem, analysed and mitigated the malware attack."
            },
            new Experience
            {
                Title = "Student Tutor",
                Company = "IIE Emeris",
                Period = "2025",
                Description = "Tutor first-year students in Mathematics and Database Design."
            }
        };

        var viewModel = new PortfolioViewModel
        {
            Profile = profile,
            Skills = skills,
            Projects = projects,
            Education = education,
            Experiences = experiences
        };

        return View(viewModel);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

