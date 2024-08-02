using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceTDD
{
    public class User
    {
        public bool CheckPassword(string password)
        {
           
            if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                return false;
            }
           
            return true;
        }
    }
}
