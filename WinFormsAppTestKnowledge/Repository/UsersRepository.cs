using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppTestKnowledge.Model;

namespace WinFormsAppTestKnowledge.Repository
{
    internal class UsersRepository
    {
        private static UsersRepository _instance = null;

        public static UsersRepository Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UsersRepository();
                }
                return _instance;
            }
        }


        private List<User> _users;
        private UsersRepository()
        {
            _users = new List<User>()
            {
                new User(){Id=1,Name="Вася",Age=15},
                new User(){Id=2,Name="Петя",Age=21},
                new User(){Id=3,Name="Маша",Age=18},
            };
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public User GetUserById(int id)
        {
            return _users.Where(user => user.Id == id).FirstOrDefault();
        }
    }
}
