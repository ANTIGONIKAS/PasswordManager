﻿using PasswordManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.Blazor.Shared.ViewModels.Password {
    public class UserEntryViewModel {

        public Guid ID { get; set; }
        public string MasterUserName { get; set; }
        public string MasterPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }

        public string Email { get; set; }

        public List<PasswordEntry> passwords { get; set; } = new();

        public UserEntryViewModel()
        {

        }
    }
}
