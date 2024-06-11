using APBD_Zadanie6.DTOs.Request;
using APBD_Zadanie6.Models;

namespace APBD_Zadanie6.Repositories.Interfaces
{
    public interface IHospitalRepository
    {
        public Task<string> AddPrescriptionAsync(PrescriptionRequestDTO request);
    }
}
