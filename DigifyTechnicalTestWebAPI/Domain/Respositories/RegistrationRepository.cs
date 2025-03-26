using DigifyWebAPI.Domain.Helper;
using DigifyWebAPI.Domain.Models;

namespace DigifyWebAPI.Domain.Respositories
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private readonly ApplicationDbContext _context;
        public RegistrationRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Registration> CreateRegistrationData(Registration model, IFormFile? npwpFile, IFormFile? powerOfAttorneyFile)
        {
            string uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");

            if (!Directory.Exists(uploadFolder))
            {
                Directory.CreateDirectory(uploadFolder);
            }

            if (npwpFile != null)
            {
                string npwpFileName = $"NPWP_{Guid.NewGuid()}_{Path.GetFileName(npwpFile.FileName)}";
                string npwpFilePath = Path.Combine(uploadFolder, npwpFileName);

                using (var stream = new FileStream(npwpFilePath, FileMode.Create))
                {
                    await npwpFile.CopyToAsync(stream);
                }

                model.NPWPFilePath = Path.Combine("uploads", npwpFileName);
            }

            if (powerOfAttorneyFile != null)
            {
                string powerOfAttorneyFileName = $"POA_{Guid.NewGuid()}_{Path.GetFileName(powerOfAttorneyFile.FileName)}";
                string powerOfAttorneyFilePath = Path.Combine(uploadFolder, powerOfAttorneyFileName);

                using (var stream = new FileStream(powerOfAttorneyFilePath, FileMode.Create))
                {
                    await powerOfAttorneyFile.CopyToAsync(stream);
                }

                model.PowerOfAttorneyFilePath = Path.Combine("uploads", powerOfAttorneyFileName);
            }

            _context.Registrations.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }
    }
}
