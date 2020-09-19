using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalDesktopApp.CarRentalLibrary.ViewModels
{
    class UserRoleViewModel
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string IsActive { get; set; }

        public int RoleID { get; set; }
        public string Role { get; set; }
    }
}
