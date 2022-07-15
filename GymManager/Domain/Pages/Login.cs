using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymManager.Domain.DataAccess;

namespace GymManager.Domain.Pages
{
    public partial class Login : Form
    {
        private EfAdminDal _adminDal;
        private EfCustomerDal _customerDal;
        public static string currentUsername;
        
        public Login()
        {
            InitializeComponent();
            _adminDal = new EfAdminDal();
            _customerDal = new EfCustomerDal();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var user = _adminDal.Get(x => x.Username == username);
            if (user is null)
            {
                lblWarn.BackColor = Color.Crimson;
                lblWarn.Text = "Please check your inputs";
                return;

            }

            if (user.Password != password)
            {
                lblWarn.BackColor = Color.Crimson;
                lblWarn.Text = "Please check your inputs";
                return;
            }

            lblWarn.Text = "Success";

            var adminForm = new AdminPage();
            adminForm.Show();
            this.Hide();



        }

        private void btnCustLogin_Click(object sender, EventArgs e)
        {

            var username = txtCustUsername.Text;
            var password = txtCustPassword.Text;
            var user = _customerDal.Get(x => x.Username == username);
            if (user is null)
            {
                lblWarn.BackColor = Color.Crimson;
                lblWarn.Text = "Please check your inputs";
                return;

            }

            if (user.Password != password)
            {   
                lblWarn.BackColor = Color.Crimson;
                lblWarn.Text = "Please check your inputs";
                return;
            }

            lblWarn.Text = "Success";
            currentUsername = txtCustUsername.Text;

            var customerForm = new Customer();
            customerForm.Show();
            this.Hide();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            currentUsername = "";
        }
    }
}
