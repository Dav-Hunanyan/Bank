﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace BankBL
{
    public class HashData
    {
        public static string Hashed_Password(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}
