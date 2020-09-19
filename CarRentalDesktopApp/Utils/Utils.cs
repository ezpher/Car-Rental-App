using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalDesktopApp
{
    public static class Utils
    {
        public static bool FormIsOpen(string name)
        {
            // Check is widnow is already open
            var OpenForms = Application.OpenForms.Cast<Form>();
            var isOpen = OpenForms.Any(q => q.Name == name);
            return isOpen;
        }

        // Default to hashed password if password param not provided
        public static string HashPassword(string password = "Password@123")
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));


                // Create a new Stringbuilder to collect the bytes and create a string
                StringBuilder builder = new StringBuilder();

                // Loop through each byte of the hashed data and format each one as a hexadecimal string.
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
