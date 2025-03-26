using DigifyWebAPI.Domain.Models;
using DigifyWebAPI.Domain.Respositories;
using Microsoft.AspNetCore.Mvc;

namespace DigifyWebAPI.Controllers
{
    public class RegistrationController : ControllerBase
    {
        private readonly ILogger<RegistrationController> _logger;
        private readonly IRegistrationRepository _registrationRepository;

        public RegistrationController(ILogger<RegistrationController> logger, IRegistrationRepository registrationRepository)
        {
            _logger = logger;
            _registrationRepository = registrationRepository;
        }

        [HttpPost("Registration")]
        public async Task<Registration> Registration(Registration model, IFormFile? npwpFile, IFormFile? powerOfAttorneyFile)
        {
            return await _registrationRepository.CreateRegistrationData(model, npwpFile, powerOfAttorneyFile);
        }
    }
}
