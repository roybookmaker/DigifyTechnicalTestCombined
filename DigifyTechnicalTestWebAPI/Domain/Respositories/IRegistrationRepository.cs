using DigifyWebAPI.Domain.Models;

namespace DigifyWebAPI.Domain.Respositories
{
    public interface IRegistrationRepository
    {
        Task<Registration> CreateRegistrationData(Registration model, IFormFile? npwpFile, IFormFile? powerOfAttorneyFile);
    }
}
