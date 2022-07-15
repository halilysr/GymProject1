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
    public partial class AdminDetail : Form
    {
        private EfAdminDal _adminDal;
        private int tempId;
        public AdminDetail()
        {
            InitializeComponent();
            _adminDal = new EfAdminDal();
        }

        private void AdminDetail_Load(object sender, EventArgs e)
        {
            PopulateTable();

        }

        private void PopulateTable()
        {
            dgwAdmin.DataSource = _adminDal.GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tempId > 0)
            {
                var admin = _adminDal.Get(x => x.Id == tempId);

                admin.Username = txtUsername.Text;
                admin.Password = txtPassword.Text;
                _adminDal.Update(admin);
                PopulateTable();
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(tempId>0)
                _adminDal.Delete(_adminDal.Get(x=>x.Id==tempId));
            PopulateTable();
        }

        private void dgwAdmin_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUsername.Text = dgwAdmin.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPassword.Text = dgwAdmin.Rows[e.RowIndex].Cells[2].Value.ToString();
            tempId = Int32.Parse(dgwAdmin.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var form = new AdminPage();
            form.Show();
            this.Hide();
        }
    }
}
