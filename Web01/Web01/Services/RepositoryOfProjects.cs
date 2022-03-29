using Web01.Models;

namespace Web01.Services
{
    public class RepositoryOfProjects
    {
        public List<ClassProjects> GetProjects()
        {
            return new List<ClassProjects>() {
            new ClassProjects {
            Title = "Minfo Network",
            Description = "Project to build a computer store",
            Link = "/Home/Projects1",
            ImageURL = "/img/Proyecto1.PNG"
            },
            new ClassProjects {
            Title = "ARKAWARE",
            Description = "Projects to create a video game store challenges",
            Link = "/Home/Projects2",
            ImageURL = "/img/Proyecto2.PNG"
            },
             new ClassProjects {
            Title = "Vaul-Tec",
            Description = "Project to create a cybersecurity company",
            Link = "/Home/Projects3",
            ImageURL = "/img/Proyecto3.PNG"
            }
            };
        }
    }
}
