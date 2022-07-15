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
    public partial class AdminPage : Form
    {
        private EfCustomerDal _customerDal;
        private EfAdminDal _adminDal;
        private EfTrainerDal _trainerDal;
        private EfTrainingDal _trainingDal;
        private EfWorkoutDal _workoutDal;
        public AdminPage()
        {
            InitializeComponent();

            _customerDal = new EfCustomerDal();
            _adminDal = new EfAdminDal();
            _trainerDal = new EfTrainerDal();
            _trainingDal = new EfTrainingDal();
            _workoutDal = new EfWorkoutDal();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            var customer = new Entities.Customer
            {
                Email = txtCustomerEmail.Text,
                Name = txtCustomerName.Text,
                Gsm = txtCustomerGSM.Text,
                Username = txtCustomerUsername.Text,
                Password = txtCustomerPassword.Text
            };

            _customerDal.Add(customer);
            UploadDataToComboBox();
        }

        private void btnTrainerAdd_Click(object sender, EventArgs e)
        {
            var trainer = new Trainer()
            {
                Email = txtTrainerEmail.Text,
                Name = txtTrainerName.Text,
                Gsm = txtTrainerGSM.Text,
                Username = txtTrainerUsername.Text,
                Password = txtTrainerPassword.Text
            };
            
            _trainerDal.Add(trainer);
            UploadDataToComboBox();
        }

        private void btnAdminAdd_Click(object sender, EventArgs e)
        {
            var admin = new Admin
            {
                Username = txtAdminUsername.Text,
                Password = txtAdminPassword.Text
            };

            _adminDal.Add(admin);
        }

        private void btnAddTraining_Click(object sender, EventArgs e)
        {
            var training = new Training
            {
                Name = txtTrainingName.Text,
                Repeat = txtTrainingRepeat.Text,
                Set = txtTrainingSet.Text,
            };

            _trainingDal.Add(training);
            UploadDataToComboBox();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            UploadDataToComboBox();
        }

        private void UploadDataToComboBox()
        {
            cmbCustomer.Items.Clear();
            cmbTraining.Items.Clear();
            cmbTrainer.Items.Clear();

            var customers = _customerDal.GetAll();
            var trainings = _trainingDal.GetAll();
            var trainers = _trainerDal.GetAll();

            foreach (var customer in customers)
            {
                cmbCustomer.Items.Add(customer.Username);
            }

            foreach (var train in trainings)
            {
                cmbTraining.Items.Add(train.Name);
            }

            foreach (var trainer in trainers)
            {
                cmbTrainer.Items.Add(trainer.Username);
            }

        }

        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
            var customer = _customerDal.Get(x => x.Username == cmbCustomer.Text);
            var training = _trainingDal.Get(x => x.Name == cmbTraining.Text);
            var trainer = _trainerDal.Get(x => x.Username == cmbTrainer.Text);

            _workoutDal.Add(new Workout
            {
                CustomerId = customer.Id,
                TrainerId = trainer.Id,
                TrainingId = training.Id
            });

        }

        private void btnDetailAdmin_Click(object sender, EventArgs e)
        {
            var form = new AdminDetail();
            form.Show();
            this.Hide();
        }

        private void btnDetailCustomer_Click(object sender, EventArgs e)
        {
            var form = new CustomerDetail();
            form.Show();
            this.Hide();
        }

        private void btnDetailTrainer_Click(object sender, EventArgs e)
        {
            var form = new TrainerDetail();
            form.Show();
            this.Hide();
        }

        private void btnDetailTraining_Click(object sender, EventArgs e)
        {
            var form = new TrainingDetail();
            form.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var form = new Login();
            form.Show();
            this.Hide();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
