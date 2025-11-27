using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labitoria.JD.Winforms.UserManager
{
    public partial class ListUsersForm : Form
    {
        public ListUsersForm()
        {
            InitializeComponent();
            UserRepository repository = new UserRepository();
            List<User> users = repository.GetAll();
            dgViewUsers.DataSource = users;
        }

        private void ListUsersForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Welcome to User Manager",
                "Greeting",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        
    }
}
