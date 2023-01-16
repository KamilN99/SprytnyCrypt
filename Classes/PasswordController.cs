using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projektPKIK.Classes
{
    internal class PasswordController
    {
        public static byte[] getPasswordHash(string password)
        {
            //generacja hashu hasła z danych komputera i hasła wprowadzonego przez użytkownika 
            SHA256Managed crypt = new SHA256Managed();
            byte[] bytes = Encoding.Unicode.GetBytes(password + GetHWID());
            return crypt.ComputeHash(bytes);
        }
        public static bool checkIfUserPasswordAreEqual(string password1, string password2)
        {
            if (password1 == password2 && !(password1 == "") && !(password2 == ""))
            {
                return true;
            }
            return false;
        }
        private static string GetHWID()
        {
            //pobranie informacji na temat sprzętu
            StringBuilder stringBuilder = new StringBuilder();

            //cpu id
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                stringBuilder.Append(obj["ProcessorId"].ToString());
            }

            //motherboard serial number
            searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            foreach (ManagementObject obj in searcher.Get())
            {
                stringBuilder.Append(obj["SerialNumber"]);
            }

            return stringBuilder.ToString();
        }
    }
}
