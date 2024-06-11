using System.ComponentModel.DataAnnotations;

namespace APBD_Zadanie6.Models
{
    public class Doctor
    {

        [Key]
        public int IdDoctor { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


        public virtual ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();    
    }
}
