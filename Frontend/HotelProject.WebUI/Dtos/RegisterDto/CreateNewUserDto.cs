using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Ad alanı boş bırakılamaz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alanı boş bırakılamaz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı alanı boş bırakılamaz")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mail alanı boş bırakılamaz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre boş bırakılamaz, Lütfen geçerli bir şifre giriniz!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrar boş bırakılamaz")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }

      
    }
}
