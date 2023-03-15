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
    public partial class AddTasksWindow : Form
    {
        public int numberoftasks;
        public AddTasksWindow(int Anumberoftasks)
        {
            InitializeComponent();
            numberoftasks = Anumberoftasks;

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
