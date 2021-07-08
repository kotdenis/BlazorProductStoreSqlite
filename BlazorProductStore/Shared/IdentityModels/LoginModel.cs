using System.ComponentModel.DataAnnotations;

namespace BlazorProductStore.Shared.IdentityModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
