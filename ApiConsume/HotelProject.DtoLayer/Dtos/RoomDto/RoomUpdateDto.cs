using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        public int RoomId { get; set; }
        [Required(ErrorMessage = "Lütfen oda numarasını yazınız")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen oda görselini seçiniz")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat bilgisi yazınız")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Lütfen başlık bilgisi yazınız")]
        [StringLength(100, ErrorMessage = "Lütfen en fazla 100 karakterlik veri girişi yapınız")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yıldız bilgisini seçiniz")]
        public double Star { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısı bilgisini yazınız")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısı bilgisini yazınız")]
        public string BathCount { get; set; }
        [Required(ErrorMessage = "Lütfen açıklama bilgisini yazınız")]
        public string Description { get; set; }
        public bool Wifi { get; set; }
    }
}
