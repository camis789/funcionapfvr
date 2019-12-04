using System;
using ApiLibrary.Models;
using ApiLibrary.Repository;
using ApiLibrary.Service.Interface;

namespace ApiLibrary.Service.Class
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public bool AddUser(User user)
        {
            if (userRepository.FindEmail(user.Email) == null)
            {
                userRepository.Add(user);
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool Login(User user)
        {
            if (userRepository.Login(user.Email, user.Password) == null)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

