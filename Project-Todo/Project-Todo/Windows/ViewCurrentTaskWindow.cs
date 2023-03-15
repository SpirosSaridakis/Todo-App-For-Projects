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
    public partial class ViewCurrentTaskWindow : Form
    {
        public ViewCurrentTaskWindow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Completed_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you have completed the selected task", "Message",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Task completed", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.None);
                textBox1.Text = "Edited text";
                //Delete the current text of the textbox
                //Delete the task from the database
                //Load the new task percentage and description on the textboxes
            }
            
        }

        private void ViewCurrentTaskWindow_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Sample text here";
        }
    }
}
