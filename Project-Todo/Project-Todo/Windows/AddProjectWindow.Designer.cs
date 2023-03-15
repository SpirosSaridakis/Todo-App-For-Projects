namespace Project_Todo.Windows
{
    partial class AddProjectWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClassBox = new System.Windows.Forms.TextBox();
            this.ProjectBox = new System.Windows.Forms.TextBox();
            this.DeadlineCal = new System.Windows.Forms.MonthCalendar();
            this.NumberOfTasksBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PriorityBox = new System.Windows.Forms.ComboBox();
            this.ToAddTasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClassBox
            // 
            this.ClassBox.Location = new System.Drawing.Point(29, 102);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(125, 27);
            this.ClassBox.TabIndex = 0;
            this.ClassBox.TextChanged += new System.EventHandler(this.ClassBox_TextChanged);
            // 
            // ProjectBox
            // 
            this.ProjectBox.Location = new System.Drawing.Point(237, 102);
            this.ProjectBox.Name = "ProjectBox";
            this.ProjectBox.Size = new System.Drawing.Size(125, 27);
            this.ProjectBox.TabIndex = 1;
            this.ProjectBox.TextChanged += new System.EventHandler(this.ProjectBox_TextChanged);
            // 
            // DeadlineCal
            // 
            this.DeadlineCal.Location = new System.Drawing.Point(447, 102);
            this.DeadlineCal.Name = "DeadlineCal";
            this.DeadlineCal.TabIndex = 3;
            this.DeadlineCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DeadlineCal_DateChanged);
            // 
            // NumberOfTasksBox
            // 
            this.NumberOfTasksBox.FormattingEnabled = true;
            this.NumberOfTasksBox.Location = new System.Drawing.Point(774, 101);
            this.NumberOfTasksBox.Name = "NumberOfTasksBox";
            this.NumberOfTasksBox.Size = new System.Drawing.Size(151, 28);
            this.NumberOfTasksBox.TabIndex = 4;
            this.NumberOfTasksBox.SelectedIndexChanged += new System.EventHandler(this.NumberOfTasksBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Project";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Deadline";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(774, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number of Tasks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(987, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Priority";
            // 
            // PriorityBox
            // 
            this.PriorityBox.FormattingEnabled = true;
            this.PriorityBox.Location = new System.Drawing.Point(987, 102);
            this.PriorityBox.Name = "PriorityBox";
            this.PriorityBox.Size = new System.Drawing.Size(151, 28);
            this.PriorityBox.TabIndex = 10;
            this.PriorityBox.SelectedIndexChanged += new System.EventHandler(this.PriorityBox_SelectedIndexChanged);
            // 
            // ToAddTasks
            // 
            this.ToAddTasks.Location = new System.Drawing.Point(1044, 492);
            this.ToAddTasks.Name = "ToAddTasks";
            this.ToAddTasks.Size = new System.Drawing.Size(94, 29);
            this.ToAddTasks.TabIndex = 11;
            this.ToAddTasks.Text = "Next";
            this.ToAddTasks.UseVisualStyleBackColor = true;
            this.ToAddTasks.Click += new System.EventHandler(this.ToAddTasks_Click);
            // 
            // AddProjectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 533);
            this.Controls.Add(this.ToAddTasks);
            this.Controls.Add(this.PriorityBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberOfTasksBox);
            this.Controls.Add(this.DeadlineCal);
            this.Controls.Add(this.ProjectBox);
            this.Controls.Add(this.ClassBox);
            this.Name = "AddProjectWindow";
            this.Text = "Add a new project";
            this.Load += new System.EventHandler(this.AddProjectWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ClassBox;
        private TextBox ProjectBox;
        private MonthCalendar DeadlineCal;
        private ComboBox NumberOfTasksBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox PriorityBox;
        private Button ToAddTasks;
    }
}