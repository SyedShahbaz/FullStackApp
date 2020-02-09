using System.ComponentModel.DataAnnotations;

namespace BackEnd.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }  

        [Required]  
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Password should be between 4 and 8 chatacters")]
        public string Password { get; set; }
    }
}