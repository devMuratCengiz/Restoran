﻿using System.ComponentModel.DataAnnotations;

namespace Restoran.WebUI.Models
{
    public class RegisterViewModel
    {
        public string NameSurname { get; set; }

        
        public string Username { get; set; }

        
        public string Password { get; set; }

        
        public string Mail { get; set; }
    }
}
