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
    public partial class Customer : Form
    {
        private EfCustomerDal _customerDal;
        private EfTrainerDal _trainerDal;
        private EfTrainingDal _trainingDal;
        private EfWorkoutDal _workoutDal;
        private Entities.Customer _currentCustomer;
        private List<WorkoutDto> list;


        public Customer()
        {
            InitializeComponent();
            _customerDal = new EfCustomerDal();
            _trainerDal = new EfTrainerDal();
            _trainingDal = new EfTrainingDal();
            _workoutDal = new EfWorkoutDal();
            list = new List<WorkoutDto>();

            _currentCustomer = _customerDal.Get(x => x.Username == Login.currentUsername);


        }

        private void Customer_Load(object sender, EventArgs e)
        {


            PopulateTable();


        }

        private void PopulateTable()
        {
           

            var workouts = _workoutDal.GetAll(x => x.CustomerId == _currentCustomer.Id);
            
            foreach(var wrk in workouts)
            {
                
                var training = _trainingDal.Get(x => x.Id == wrk.TrainingId);
                var trainer = _trainerDal.Get(x => x.Id == wrk.TrainerId);

                list.Add(new WorkoutDto
                {
                    CustomerName = _currentCustomer.Name,
                    WorkoutName = training.Name,
                    Repeat = training.Repeat,
                    Set = training.Set,
                    TrainerName = trainer.Name
                });

            }

            dgwWorkout.DataSource = list;
            lblMessage.Text = "Welcome " + _currentCustomer.Name + "\n Your Workout Programm is Ready";

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var form = new Login();
            form.Show();
            this.Hide();
        }

        private void dgwWorkout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
