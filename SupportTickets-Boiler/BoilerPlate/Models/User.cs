﻿namespace BoilerPlate.Models
{
    public class User
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public bool IsCompany { get; set; } = false;
    }
}