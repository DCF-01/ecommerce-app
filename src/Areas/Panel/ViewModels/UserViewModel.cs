using Microsoft.AspNetCore.Identity;
using app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.ViewModels {
    public class UserViewModel {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string CurrentRole { get; set; }
        public string RoleSelected { get; set; }
        public List<string> GetRoles { get; set; }

    }
}
