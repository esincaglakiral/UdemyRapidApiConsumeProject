﻿namespace HotelProject.WebUI.Dtos.AboutDto
{
    public class UpdateAboutDto
    {
        public int AboutId { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Content { get; set; }
        public int RoomCount { get; set; }
        public int StafCount { get; set; }
        public int CustomerCount { get; set; }
    }
}
