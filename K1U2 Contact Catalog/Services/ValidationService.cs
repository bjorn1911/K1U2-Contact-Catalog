using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1U2_Contact_Catalog.Services
{
    public static class ValidationService
    {
        public static bool IsValidEmail(string email) // Provided by Teacher
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch { return false; }
        }
    }
}
