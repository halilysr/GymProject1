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
    public partial class TrainerDetail : Form
    {
        private EfTrainerDal _trainerDal;
        private int tempId;
        public TrainerDetail()
        {
            InitializeComponent();
            _trainerDal = new EfTrainerDal();
        }

        private void dgwTrainer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUsername.Text = dgwTrainer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPassword.Text = dgwTrainer.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtName.Text = dgwTrainer.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = dgwTrainer.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtGsm.Text = dgwTrainer.Rows[e.RowIndex].Cells[5].Value.ToString();

            tempId = Int32.Parse(dgwTrainer.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void TrainerDetail_Load(object sender, EventArgs e)
        {
            PopulateTable();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var trainer = _trainerDal.Get(x => x.Id == tempId);
            trainer.Name = txtName.Text;
            trainer.Gsm = txtGsm.Text;
            trainer.Password = txtPassword.Text;
            trainer.Username = txtUsername.Text;

            _trainerDal.Update(trainer);

            PopulateTable();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var trainer = _trainerDal.Get(x => x.Id == tempId);
            _trainerDal.Delete(trainer);

            PopulateTable();
        }

        private void PopulateTable()
        {
            dgwTrainer.DataSource = _trainerDal.GetAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var form = new AdminPage();
            form.Show();
            this.Hide();
        }
    }
}
