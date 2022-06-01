using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class User
    {
        public string UserName;
        private string Password;

        public void SetPassword(string password)
        {
            if(!String.IsNullOrWhiteSpace(password) && password.Length>7 &&  HasUpper(password) && HasDigit(password))
                this.Password = password;
        }

        public string GetPassword()
        {
            return Password;
        }

        public bool HasUpper(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                    return true;
            }

            return false;
        }

        public bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                    return true;
            }

            return false;
        }
    }
}
