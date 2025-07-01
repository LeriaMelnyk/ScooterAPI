using System;
using System.ComponentModel.DataAnnotations;

namespace Scooter.BLL.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Повне ім'я є обов'язковим")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Ім'я повинно містити від 2 до 100 символів")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email є обов'язковим")]
        [EmailAddress(ErrorMessage = "Невірний формат email")]
        public string Email { get; set; }

        public bool IsVerified { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
