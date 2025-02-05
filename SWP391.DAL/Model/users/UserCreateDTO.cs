﻿using SWP391.DAL.Entities;

namespace SWP391.DAL.Model.users
{
    public class UserCreateDTO
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string FullName { get; set; }
        public string? Image { get; set; }
    }
}
