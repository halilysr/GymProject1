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
using GymManager.Domain.Entities;

namespace GymManager.Domain.Pages
{
    public partial class CustomerDetail : Form
    {
        private EfCustomerDal _customerDal;
        private int tempId;
        public CustomerDetail()
        {
            InitializeComponent();
            _customerDal = new EfCustomerDal();
        }

        private void CustomerDetail_Load(object sender, EventArgs e)
        {
            
            PopulateTable();

        }


        private void dgwCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //string value1 = row.Cells[0].Value.ToString();
            //string value2 = row.Cells[1].Value.ToString();
            txtUsername.Text = dgwCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPassword.Text = dgwCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtName.Text = dgwCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = dgwCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtGsm.Text = dgwCustomer.Rows[e.RowIndex].Cells[5].Value.ToString();

            tempId = Int32.Parse(dgwCustomer.Rows[e.RowIndex].Cells[0].Value.ToString());



        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {

            
            var customer = _customerDal.Get(x=>x.Id==tempId);
            customer.Username = txtUsername.Text;
            customer.Password = txtPassword.Text;
            customer.Name = txtName.Text;
            customer.Email = txtEmail.Text;
            customer.Gsm = txtGsm.Text;

            _customerDal.Update(customer);

            PopulateTable();


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            var customer = _customerDal.Get(x=>x.Id==tempId);

            
            _customerDal.Delete(customer);
            PopulateTable();

        }

        private void PopulateTable()
        {
            dgwCustomer.DataSource = _customerDal.GetAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var form = new AdminPage();
            form.Show();
            this.Hide();
        }
    }
}
