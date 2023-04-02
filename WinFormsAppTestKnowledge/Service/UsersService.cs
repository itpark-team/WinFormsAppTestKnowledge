using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppTestKnowledge.Model;
using WinFormsAppTestKnowledge.Repository;

namespace WinFormsAppTestKnowledge.Service
{
    internal class UsersService
    {
        private UsersRepository _usersRepository;

        public UsersService()
        {
            _usersRepository = UsersRepository.Instance;
        }

        public List<User> GetAllUsers()
        {
            return _usersRepository.GetAllUsers();
        }

        public User GetUserById(int id)
        {
            return _usersRepository.GetUserById(id);
        }
    }
}
