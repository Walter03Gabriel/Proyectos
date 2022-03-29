using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web01.Models;
using Grpc.Core;
using System.Net.Mail;
using Web01.Services;

namespace Web01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Vname = "Walter Aparicio de Monlau";
            return View();
        }
        public IActionResult Experiencia()
        {
            
            return View();
        }
        public IActionResult Estudios()
        {

            return View();
        }
        public IActionResult MisProyectos()
        {
            ViewBag.Vname = new RepositoryOfProjects().GetProjects();
            return View();
        }
        public IActionResult Projects1()
        {
            return View();
        }
        public IActionResult Projects2()
        {

            return View();
        }
        public IActionResult Projects3()
        {

            return View();
        }

        public IActionResult MiCurriculum()
        {
            return View();
        }

        public IActionResult Contactar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult metodoEmail(ClassEmail classEmail) {
            email(classEmail);
            return View("Contactar");
        }

        private void email(ClassEmail classEmail)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add("walter.gabriel.03@gmail.com");
            mail.From = new MailAddress(classEmail.email);
            mail.Subject = classEmail.asunto;
            mail.Body = classEmail.mensaje;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("minfo.network@gmail.com", "Minfo_Network03");
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }

        public IActionResult Habilidades()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}