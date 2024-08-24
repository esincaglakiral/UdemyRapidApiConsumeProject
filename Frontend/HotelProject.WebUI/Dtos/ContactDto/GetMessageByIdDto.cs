﻿namespace HotelProject.WebUI.Dtos.ContactDto
{
    public class GetMessageByIdDto
    {
        public int SendMessageId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string RecieverMail { get; set; }
        public string RecieverName { get; set; }
        public string SenderName { get; set; }
        public string SenderMail { get; set; }
        public DateTime SenderDate { get; set; }
    }
}