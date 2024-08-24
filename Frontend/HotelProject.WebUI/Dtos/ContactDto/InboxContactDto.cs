namespace HotelProject.WebUI.Dtos.ContactDto
{
    public class InboxContactDto
    {
        public int ContactId { get; set; }
        public string NameSurname { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public DateTime Date { get; set; }

    }
}
