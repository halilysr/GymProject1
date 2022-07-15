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
    public partial class TrainingDetail : Form
    {
        private EfTrainingDal _trainingDal;
        private int tempId;
        public TrainingDetail()
        {
            InitializeComponent();
            _trainingDal = new EfTrainingDal();
        }


        private void TrainingDetail_Load(object sender, EventArgs e)
        {
            PopulateTable();
        }
        private void dgwTraining_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtName.Text = dgwTraining.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRepeat.Text = dgwTraining.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRepeat.Text = dgwTraining.Rows[e.RowIndex].Cells[2].Value.ToString();
            tempId = Int32.Parse(dgwTraining.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tempId > 0)
            {
                var training = _trainingDal.Get(x => x.Id == tempId);
                training.Name = txtName.Text;
                training.Repeat = txtRepeat.Text;
                training.Set = txtSet.Text;

                _trainingDal.Update(training);

                PopulateTable();
            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tempId > 0)
            {
                _trainingDal.Delete(_trainingDal.Get(x => x.Id == tempId));
                
                PopulateTable();
            }
           
        }

        private void PopulateTable()
        {
            dgwTraining.DataSource = _trainingDal.GetAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var form = new AdminPage();
            form.Show();
            this.Hide();
        }
    }
}
