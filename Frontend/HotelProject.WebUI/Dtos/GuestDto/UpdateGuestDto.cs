﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.GuestDto
{
    public class UpdateGuestDto
    {
        public int GuestId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
    }
}