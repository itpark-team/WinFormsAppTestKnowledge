using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppTestKnowledge.Controller;

namespace WinFormsAppTestKnowledge.UI
{
    public partial class FormUsers : Form
    {
        private FormUsersController _formUsersController;

        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            _formUsersController = new FormUsersController(this);
        }

        private void buttonGetAllUsers_Click(object sender, EventArgs e)
        {
            _formUsersController.PrintAllUsersToDataGridViewUsers();
        }

        private void buttonGetUserById_Click(object sender, EventArgs e)
        {
            _formUsersController.PrintUserByIdDataGridViewUsers();
        }
    }
}
