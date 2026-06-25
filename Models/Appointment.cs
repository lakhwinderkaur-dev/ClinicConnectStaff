using System.ComponentModel.DataAnnotations;

namespace ClinicConnectStaff.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public int PatientId { get; set; }
        public Patient? Patient { get; set; }

        [Required]
        public string DoctorName { get; set; } = string.Empty;

        public string Specialty { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }

        public string AppointmentTime { get; set; } = string.Empty;

        public string Status { get; set; } = "Upcoming";

        public string Notes { get; set; } = string.Empty;
    }
}