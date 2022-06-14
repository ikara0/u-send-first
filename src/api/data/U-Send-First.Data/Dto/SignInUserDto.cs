using System.ComponentModel.DataAnnotations;

namespace U_Send_First.Data.Dto
{
    public class SignInUserDto
    {
        [Required(ErrorMessage = "E-Mail is required")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}