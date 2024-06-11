using APBD_Zadanie6.DTOs.Response;
using APBD_Zadanie6.Models;

namespace APBD_Zadanie6.DTOs.Request;

public class PrescriptionRequestDTO
{
    public PatientDTO Patient { get; set; }
    
    public List<MedicamentDTO> Medicaments { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
}