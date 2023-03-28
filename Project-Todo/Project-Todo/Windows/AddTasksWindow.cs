using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Todo.Data;
using Project_Todo.Models;

namespace Project_Todo.Windows
{
    public partial class AddTasksWindow : Form
    {
        public int numberoftasks;
        public int projectId;
        ApplicationDbContext _context;
        public AddTasksWindow(int Anumberoftasks, int projectId, ApplicationDbContext context)
        {
            InitializeComponent();
            numberoftasks = Anumberoftasks;
            this.projectId= projectId;
            _context = context;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            int counter = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Models.Task task = new Models.Task((string)row.Cells[0].Value, (int)(1 / numberoftasks), projectId,counter);
                counter++;
                _context.Tasks.Add(task);
                _context.SaveChanges();
                //Prepei na kaneis add ta tasks
            }
            MessageBox.Show("Tasks saved successfully", "Congratulations",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void AddTasksWindow_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowCount = numberoftasks;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
