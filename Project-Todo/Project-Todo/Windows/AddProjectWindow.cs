using Project_Todo.Data;
using Project_Todo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Todo.Windows
{
    public partial class AddProjectWindow : Form
    {
        ApplicationDbContext _context;
        public AddProjectWindow(ApplicationDbContext context)
        {
            InitializeComponent();
            _context= context;
        }

        private void AddProjectWindow_Load(object sender, EventArgs e)
        {
            var datasource = new List<int>();
            for(int i = 0; i < 11; i++)
            {
                datasource.Add(i);
            }
            NumberOfTasksBox.DataSource= datasource;
        }

        private void DeadlineCal_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void ClassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumberOfTasksBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PriorityBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ToAddTasks_Click(object sender, EventArgs e)
        {
            /*
            //GET THE INFO FROM THE TEXTBOXES AND OTHER STUFF AND CREATE THE PROJECT
            Project project = new Project("Final Project","information retrieval", DateTime.Now,1);
            _context.Projects.Add(project);
            _context.SaveChanges();
            */
            int numberoftasks = NumberOfTasksBox.SelectedIndex;
            if (numberoftasks==0) 
            {
                MessageBox.Show("Please select a number of tasks", "Error, you forgot to select the number of tasks",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AddTasksWindow window = new AddTasksWindow(numberoftasks);
            window.Show();
        }
    }
}
