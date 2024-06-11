using APBD_Zadanie6.DTOs.Request;
using APBD_Zadanie6.Models;
using APBD_Zadanie6.Repositories.Interfaces;

namespace APBD_Zadanie6.Repositories
{
    public class HospitalRepository : IHospitalRepository
    {
        private readonly Context _context;

        public HospitalRepository(Context context)
        {
            _context = context;
        }

        public async Task<string> AddPrescriptionAsync(PrescriptionRequestDTO request)
        {
            _context.Prescriptions.Add(request);
            await _context.SaveChangesAsync();
        }
    }
}
