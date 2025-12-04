using Kebabs.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kebabs.Services
{
    public class AuthService
    {
        public User? Login(string username, string password)
        {
            return InMemoryDatabase.Users.FirstOrDefault(
                u => u.Username == username && u.Password == password);
        }
    }
}
