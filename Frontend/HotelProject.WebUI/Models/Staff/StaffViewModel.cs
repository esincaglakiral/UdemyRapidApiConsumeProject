namespace HotelProject.WebUI.Models.Staff
{
    public class StaffViewModel  //consume etmesi için jsondaki datalar ile propertydeki datalar aynı olmalı
    {
        public int StaffId { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
    }
}
