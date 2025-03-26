using DigifyWebAPP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace DigifyWebAPP.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ILogger<RegistrationController> _logger;
        private readonly HttpClient _httpClient;

        public RegistrationController(ILogger<RegistrationController> logger, HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Registration model, IFormFile? npwpFile, IFormFile? powerOfAttorneyFile)
        {
            using var content = new MultipartFormDataContent();

            content.Add(new StringContent(model.CompanyName), nameof(model.CompanyName));
            content.Add(new StringContent(model.NPWP), nameof(model.NPWP));
            content.Add(new StringContent(model.DirectorName), nameof(model.DirectorName));
            content.Add(new StringContent(model.PICName), nameof(model.PICName));
            content.Add(new StringContent(model.Email), nameof(model.Email));
            content.Add(new StringContent(model.PhoneNumber), nameof(model.PhoneNumber));

            if (npwpFile != null)
            {
                var npwpFileContent = new StreamContent(npwpFile.OpenReadStream());
                npwpFileContent.Headers.ContentType = new MediaTypeHeaderValue(npwpFile.ContentType);
                content.Add(npwpFileContent, nameof(npwpFile), npwpFile.FileName);
            }

            if (powerOfAttorneyFile != null)
            {
                var powerOfAttorneyFileContent = new StreamContent(powerOfAttorneyFile.OpenReadStream());
                powerOfAttorneyFileContent.Headers.ContentType = new MediaTypeHeaderValue(powerOfAttorneyFile.ContentType);
                content.Add(powerOfAttorneyFileContent, nameof(powerOfAttorneyFile), powerOfAttorneyFile.FileName);
            }

            var response = await _httpClient.PostAsync("https://localhost:7005/Registration", content);

            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "An error occurred while processing your request.");
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
