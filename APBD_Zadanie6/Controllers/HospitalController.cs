using APBD_Zadanie6.DTOs.Request;
using APBD_Zadanie6.Models;
using APBD_Zadanie6.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Zadanie6.Controllers
{
    [ApiController]
    [Route("Api/hospital")]
    public class HospitalController : ControllerBase
    {
        private readonly IHospitalRepository _repository;

        public HospitalController(IHospitalRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public Task<IActionResult> AddPrescription([FromBody] PrescriptionRequestDTO request)
        {
            var test = _repository.AddPrescriptionAsync(request);
            return Ok(test);
        }
    }
}
