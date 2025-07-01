using System.ComponentModel.DataAnnotations;

namespace Scooter.BLL.DTO
{
    public class VehicleDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Модель транспортного засобу є обов'язковою")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Модель повинна містити від 2 до 100 символів")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Реєстраційний номер є обов'язковим")]
        [StringLength(20, ErrorMessage = "Реєстраційний номер не може бути довшим за 20 символів")]
        public string RegistrationNumber { get; set; }

        public bool IsAvailable { get; set; }
    }
}
