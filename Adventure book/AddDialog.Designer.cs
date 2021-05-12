
namespace Adventure_book
{
    partial class AddDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TaskName = new System.Windows.Forms.Label();
            this.TaskDescription = new System.Windows.Forms.Label();
            this.InTaskName = new System.Windows.Forms.TextBox();
            this.InTaskDescription = new System.Windows.Forms.TextBox();
            this.TaskDeadline = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Task";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(574, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(612, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TaskName
            // 
            this.TaskName.AutoSize = true;
            this.TaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TaskName.ForeColor = System.Drawing.Color.White;
            this.TaskName.Location = new System.Drawing.Point(17, 78);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(91, 20);
            this.TaskName.TabIndex = 10;
            this.TaskName.Text = "Task name:";
            this.TaskName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TaskName.Click += new System.EventHandler(this.TaskName_Click);
            // 
            // TaskDescription
            // 
            this.TaskDescription.AutoSize = true;
            this.TaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TaskDescription.ForeColor = System.Drawing.Color.White;
            this.TaskDescription.Location = new System.Drawing.Point(17, 157);
            this.TaskDescription.Name = "TaskDescription";
            this.TaskDescription.Size = new System.Drawing.Size(128, 20);
            this.TaskDescription.TabIndex = 11;
            this.TaskDescription.Text = "Task description:";
            this.TaskDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InTaskName
            // 
            this.InTaskName.Location = new System.Drawing.Point(21, 101);
            this.InTaskName.Name = "InTaskName";
            this.InTaskName.Size = new System.Drawing.Size(283, 20);
            this.InTaskName.TabIndex = 12;
            this.InTaskName.TextChanged += new System.EventHandler(this.InTaskName_TextChanged);
            // 
            // InTaskDescription
            // 
            this.InTaskDescription.Location = new System.Drawing.Point(21, 181);
            this.InTaskDescription.Multiline = true;
            this.InTaskDescription.Name = "InTaskDescription";
            this.InTaskDescription.Size = new System.Drawing.Size(283, 182);
            this.InTaskDescription.TabIndex = 13;
            this.InTaskDescription.TextChanged += new System.EventHandler(this.InTaskDescription_TextChanged);
            // 
            // TaskDeadline
            // 
            this.TaskDeadline.AutoSize = true;
            this.TaskDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TaskDeadline.ForeColor = System.Drawing.Color.White;
            this.TaskDeadline.Location = new System.Drawing.Point(381, 78);
            this.TaskDeadline.Name = "TaskDeadline";
            this.TaskDeadline.Size = new System.Drawing.Size(114, 20);
            this.TaskDeadline.TabIndex = 14;
            this.TaskDeadline.Text = "Task Deadline:";
            this.TaskDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(385, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 25);
            this.button3.TabIndex = 16;
            this.button3.Text = "Confirm task";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(385, 312);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 25);
            this.button4.TabIndex = 17;
            this.button4.Text = "Cancel task";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(385, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // AddDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(671, 375);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TaskDeadline);
            this.Controls.Add(this.InTaskDescription);
            this.Controls.Add(this.InTaskName);
            this.Controls.Add(this.TaskDescription);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDialog";
            this.Opacity = 0.9D;
            this.Text = "AddDialog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label TaskName;
        public System.Windows.Forms.Label TaskDescription;
        private System.Windows.Forms.TextBox InTaskName;
        private System.Windows.Forms.TextBox InTaskDescription;
        public System.Windows.Forms.Label TaskDeadline;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}