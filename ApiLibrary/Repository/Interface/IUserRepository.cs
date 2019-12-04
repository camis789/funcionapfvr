using System;
using ApiLibrary.Models;

namespace ApiLibrary.Repository
{
    public interface IUserRepository
    {
        void Add(User user);
        User FindEmail(string email);
        User Login(string email, string password);
    }
}
