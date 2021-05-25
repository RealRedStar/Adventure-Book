
using System;

namespace Adventure_book
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        public void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menu1 = new System.Windows.Forms.Panel();
            this.Coins = new System.Windows.Forms.TextBox();
            this.txtCoins = new System.Windows.Forms.Label();
            this.magicalChest = new System.Windows.Forms.PictureBox();
            this.normalChest = new System.Windows.Forms.PictureBox();
            this.magicalChestLabel = new System.Windows.Forms.Label();
            this.normalChestLabel = new System.Windows.Forms.Label();
            this.menu2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.AddHomework = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.settings = new System.Windows.Forms.Button();
            this.character = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.Button();
            this.chestroom = new System.Windows.Forms.Button();
            this.menu3 = new System.Windows.Forms.Panel();
            this.menu4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.whiteMode = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magicalChest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalChest)).BeginInit();
            this.menu2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.menu4.SuspendLayout();
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adventure Task Book";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
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
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.menu1.Controls.Add(this.Coins);
            this.menu1.Controls.Add(this.txtCoins);
            this.menu1.Controls.Add(this.magicalChest);
            this.menu1.Controls.Add(this.normalChest);
            this.menu1.Controls.Add(this.magicalChestLabel);
            this.menu1.Controls.Add(this.normalChestLabel);
            this.menu1.Location = new System.Drawing.Point(95, 56);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(564, 326);
            this.menu1.TabIndex = 1;
            // 
            // Coins
            // 
            this.Coins.Location = new System.Drawing.Point(406, 11);
            this.Coins.Name = "Coins";
            this.Coins.ReadOnly = true;
            this.Coins.Size = new System.Drawing.Size(100, 20);
            this.Coins.TabIndex = 13;
            this.Coins.TextChanged += new System.EventHandler(this.Coins_TextChanged);
            // 
            // txtCoins
            // 
            this.txtCoins.AutoSize = true;
            this.txtCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCoins.ForeColor = System.Drawing.Color.White;
            this.txtCoins.Location = new System.Drawing.Point(347, 10);
            this.txtCoins.Name = "txtCoins";
            this.txtCoins.Size = new System.Drawing.Size(53, 20);
            this.txtCoins.TabIndex = 12;
            this.txtCoins.Text = "Coins:";
            this.txtCoins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // magicalChest
            // 
            this.magicalChest.Image = global::Adventure_book.Properties.Resources.magicalChestBig;
            this.magicalChest.Location = new System.Drawing.Point(352, 128);
            this.magicalChest.Name = "magicalChest";
            this.magicalChest.Size = new System.Drawing.Size(150, 151);
            this.magicalChest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.magicalChest.TabIndex = 11;
            this.magicalChest.TabStop = false;
            this.magicalChest.Click += new System.EventHandler(this.magicalChest_Click);
            this.magicalChest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.magicalChest_Click);
            this.magicalChest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.magicalChest_MouseDown);
            this.magicalChest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.magicalChest_MouseMove);
            this.magicalChest.MouseUp += new System.Windows.Forms.MouseEventHandler(this.magicalChest_MouseUp);
            // 
            // normalChest
            // 
            this.normalChest.Image = global::Adventure_book.Properties.Resources.normalChestBig;
            this.normalChest.Location = new System.Drawing.Point(72, 128);
            this.normalChest.Name = "normalChest";
            this.normalChest.Size = new System.Drawing.Size(150, 151);
            this.normalChest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.normalChest.TabIndex = 10;
            this.normalChest.TabStop = false;
            this.normalChest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.normalChest_Click);
            this.normalChest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.normalChest_MouseDown);
            this.normalChest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.normalChest_MouseMove);
            this.normalChest.MouseUp += new System.Windows.Forms.MouseEventHandler(this.normalChest_MouseUp);
            // 
            // magicalChestLabel
            // 
            this.magicalChestLabel.AutoSize = true;
            this.magicalChestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.magicalChestLabel.ForeColor = System.Drawing.Color.White;
            this.magicalChestLabel.Location = new System.Drawing.Point(420, 282);
            this.magicalChestLabel.Name = "magicalChestLabel";
            this.magicalChestLabel.Size = new System.Drawing.Size(18, 20);
            this.magicalChestLabel.TabIndex = 9;
            this.magicalChestLabel.Text = "1";
            this.magicalChestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.magicalChestLabel.Click += new System.EventHandler(this.magicalChestLabel_Click);
            // 
            // normalChestLabel
            // 
            this.normalChestLabel.AutoSize = true;
            this.normalChestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.normalChestLabel.ForeColor = System.Drawing.Color.White;
            this.normalChestLabel.Location = new System.Drawing.Point(138, 282);
            this.normalChestLabel.Name = "normalChestLabel";
            this.normalChestLabel.Size = new System.Drawing.Size(18, 20);
            this.normalChestLabel.TabIndex = 8;
            this.normalChestLabel.Text = "5";
            this.normalChestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.normalChestLabel.Click += new System.EventHandler(this.normalChestLabel_Click);
            // 
            // menu2
            // 
            this.menu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.menu2.Controls.Add(this.button3);
            this.menu2.Controls.Add(this.AddHomework);
            this.menu2.Controls.Add(this.DataGrid);
            this.menu2.Location = new System.Drawing.Point(95, 56);
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(564, 326);
            this.menu2.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(480, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 14;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddHomework
            // 
            this.AddHomework.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.AddHomework.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddHomework.ForeColor = System.Drawing.Color.White;
            this.AddHomework.Location = new System.Drawing.Point(518, 45);
            this.AddHomework.Name = "AddHomework";
            this.AddHomework.Size = new System.Drawing.Size(32, 32);
            this.AddHomework.TabIndex = 3;
            this.AddHomework.Text = "+";
            this.AddHomework.UseVisualStyleBackColor = false;
            this.AddHomework.Click += new System.EventHandler(this.AddHomework_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGrid.Location = new System.Drawing.Point(14, 83);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(536, 231);
            this.DataGrid.TabIndex = 13;
            this.DataGrid.Visible = false;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick_1);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.ForeColor = System.Drawing.Color.White;
            this.settings.Image = global::Adventure_book.Properties.Resources.gearBlue;
            this.settings.Location = new System.Drawing.Point(12, 305);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(77, 77);
            this.settings.TabIndex = 6;
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // character
            // 
            this.character.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.character.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.character.ForeColor = System.Drawing.Color.White;
            this.character.Image = global::Adventure_book.Properties.Resources.userBlue;
            this.character.Location = new System.Drawing.Point(12, 222);
            this.character.Name = "character";
            this.character.Size = new System.Drawing.Size(77, 77);
            this.character.TabIndex = 5;
            this.character.UseVisualStyleBackColor = false;
            this.character.Click += new System.EventHandler(this.character_Click);
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendar.ForeColor = System.Drawing.Color.White;
            this.calendar.Image = global::Adventure_book.Properties.Resources.calendarBlue;
            this.calendar.Location = new System.Drawing.Point(12, 139);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(77, 77);
            this.calendar.TabIndex = 4;
            this.calendar.UseVisualStyleBackColor = false;
            this.calendar.Click += new System.EventHandler(this.calendar_Click);
            // 
            // chestroom
            // 
            this.chestroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.chestroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chestroom.ForeColor = System.Drawing.Color.White;
            this.chestroom.Image = global::Adventure_book.Properties.Resources.chestBlue;
            this.chestroom.Location = new System.Drawing.Point(12, 56);
            this.chestroom.Name = "chestroom";
            this.chestroom.Size = new System.Drawing.Size(77, 77);
            this.chestroom.TabIndex = 3;
            this.chestroom.UseVisualStyleBackColor = false;
            this.chestroom.Click += new System.EventHandler(this.chestroom_Click);
            // 
            // menu3
            // 
            this.menu3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.menu3.Location = new System.Drawing.Point(95, 56);
            this.menu3.Name = "menu3";
            this.menu3.Size = new System.Drawing.Size(564, 327);
            this.menu3.TabIndex = 12;
            // 
            // menu4
            // 
            this.menu4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.menu4.Controls.Add(this.label4);
            this.menu4.Controls.Add(this.whiteMode);
            this.menu4.Controls.Add(this.label2);
            this.menu4.Location = new System.Drawing.Point(95, 56);
            this.menu4.Name = "menu4";
            this.menu4.Size = new System.Drawing.Size(564, 327);
            this.menu4.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "White Mode:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // whiteMode
            // 
            this.whiteMode.AutoSize = true;
            this.whiteMode.Location = new System.Drawing.Point(142, 61);
            this.whiteMode.Name = "whiteMode";
            this.whiteMode.Size = new System.Drawing.Size(29, 17);
            this.whiteMode.TabIndex = 4;
            this.whiteMode.Text = " ";
            this.whiteMode.UseVisualStyleBackColor = true;
            this.whiteMode.CheckedChanged += new System.EventHandler(this.whiteMode_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Settings";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(671, 395);
            this.ControlBox = false;
            this.Controls.Add(this.settings);
            this.Controls.Add(this.character);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.chestroom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.menu2);
            this.Controls.Add(this.menu3);
            this.Controls.Add(this.menu4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magicalChest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalChest)).EndInit();
            this.menu2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.menu4.ResumeLayout(false);
            this.menu4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel menu1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button chestroom;
        public System.Windows.Forms.Button calendar;
        public System.Windows.Forms.Button character;
        public System.Windows.Forms.Label magicalChestLabel;
        public System.Windows.Forms.Label normalChestLabel;
        public System.Windows.Forms.Button settings;
        public System.Windows.Forms.PictureBox normalChest;
        public System.Windows.Forms.PictureBox magicalChest;
        public System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Panel menu2;
        private System.Windows.Forms.Panel menu3;
        private System.Windows.Forms.Panel menu4;
        public System.Windows.Forms.Button AddHomework;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Coins;
        public System.Windows.Forms.Label txtCoins;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox whiteMode;
        public System.Windows.Forms.Label label4;
    }
}

