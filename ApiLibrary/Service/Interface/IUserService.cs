using System;
using System.Collections.Generic;
using ApiLibrary.Models;
namespace ApiLibrary.Service.Interface
{
    public interface IUserService
    {
        bool AddUser(User user);
    }
}
