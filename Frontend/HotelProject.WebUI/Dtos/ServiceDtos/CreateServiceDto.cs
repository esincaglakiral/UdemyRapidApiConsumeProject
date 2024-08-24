using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDtos
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Hizmet için ikon linki yaznız")]
        public string ServiceIcon { get; set; }


        [Required(ErrorMessage = "Hizmet için başlık yazınız")]
        [MaxLength(100, ErrorMessage = "Başlık en fazla 100 karakter olmalıdır.")]
        public string Title { get; set; }


        [Required(ErrorMessage = "Hizmet için açıklama yaznız")]
        [MaxLength(500, ErrorMessage = "Başlık en fazla 500 karakter olmalıdır.")]
        public string Description { get; set; }
    }
}
