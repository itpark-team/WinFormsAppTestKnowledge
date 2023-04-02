using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppTestKnowledge.Model;
using WinFormsAppTestKnowledge.Repository;
using WinFormsAppTestKnowledge.Service;
using WinFormsAppTestKnowledge.UI;

namespace WinFormsAppTestKnowledge.Controller
{
    internal class FormUsersController
    {
        private FormUsers _formUsers;
        private UsersService _usersService;

        DataGridView _dataGridViewUsers;
        NumericUpDown _numericUpDownUserId;

        public FormUsersController(FormUsers formUsers)
        {
            _formUsers = formUsers;
            _usersService = new UsersService();

            InitComponents();
        }

        private void InitComponents()
        {
            _dataGridViewUsers = (DataGridView)_formUsers.Controls["dataGridViewUsers"];
            _numericUpDownUserId = (NumericUpDown)_formUsers.Controls["numericUpDownUserId"];
        }

        public void PrintAllUsersToDataGridViewUsers()
        {
            _dataGridViewUsers.DataSource = null;
            _dataGridViewUsers.DataSource = _usersService.GetAllUsers();
        }

        public void PrintUserByIdDataGridViewUsers()
        {
            _dataGridViewUsers.DataSource = null;

            int id = (int)_numericUpDownUserId.Value;
            _dataGridViewUsers.DataSource = new List<User>()
            {
                _usersService.GetUserById(id)
            };
        }
    }
}
