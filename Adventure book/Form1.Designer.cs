
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
        protected void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.menu1 = new System.Windows.Forms.Panel();
            this.Coins = new System.Windows.Forms.TextBox();
            this.CoinsLabel = new System.Windows.Forms.Label();
            this.magicalChest = new System.Windows.Forms.PictureBox();
            this.NormalChest = new System.Windows.Forms.PictureBox();
            this.MagicalChestLabel = new System.Windows.Forms.Label();
            this.NormalChestLabel = new System.Windows.Forms.Label();
            this.menu2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.AddHomework = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.SettingsMenu = new System.Windows.Forms.Button();
            this.Character = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.Button();
            this.Chestroom = new System.Windows.Forms.Button();
            this.menu3 = new System.Windows.Forms.Panel();
            this.menu4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.whiteMode = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.magicalChest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NormalChest)).BeginInit();
            this.menu2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.menu4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MinimizeButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 38);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adventure Task Book";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseUp);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Location = new System.Drawing.Point(574, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(32, 32);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(612, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(32, 32);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.menu1.Controls.Add(this.Coins);
            this.menu1.Controls.Add(this.CoinsLabel);
            this.menu1.Controls.Add(this.magicalChest);
            this.menu1.Controls.Add(this.NormalChest);
            this.menu1.Controls.Add(this.MagicalChestLabel);
            this.menu1.Controls.Add(this.NormalChestLabel);
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
            this.Coins.Text = "0";
            this.Coins.TextChanged += new System.EventHandler(this.Coins_TextChanged);
            // 
            // CoinsLabel
            // 
            this.CoinsLabel.AutoSize = true;
            this.CoinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CoinsLabel.ForeColor = System.Drawing.Color.White;
            this.CoinsLabel.Location = new System.Drawing.Point(347, 10);
            this.CoinsLabel.Name = "CoinsLabel";
            this.CoinsLabel.Size = new System.Drawing.Size(53, 20);
            this.CoinsLabel.TabIndex = 12;
            this.CoinsLabel.Text = "Coins:";
            this.CoinsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.magicalChest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MagicalChest_Click);
            this.magicalChest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MagicalChest_MouseDown);
            this.magicalChest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MagicalChest_MouseMove);
            this.magicalChest.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MagicalChest_MouseUp);
            // 
            // NormalChest
            // 
            this.NormalChest.Image = global::Adventure_book.Properties.Resources.normalChestBig;
            this.NormalChest.Location = new System.Drawing.Point(72, 128);
            this.NormalChest.Name = "NormalChest";
            this.NormalChest.Size = new System.Drawing.Size(150, 151);
            this.NormalChest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NormalChest.TabIndex = 10;
            this.NormalChest.TabStop = false;
            this.NormalChest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NormalChest_Click);
            this.NormalChest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NormalChest_MouseDown);
            this.NormalChest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NormalChest_MouseMove);
            this.NormalChest.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NormalChest_MouseUp);
            // 
            // MagicalChestLabel
            // 
            this.MagicalChestLabel.AutoSize = true;
            this.MagicalChestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MagicalChestLabel.ForeColor = System.Drawing.Color.White;
            this.MagicalChestLabel.Location = new System.Drawing.Point(420, 282);
            this.MagicalChestLabel.Name = "MagicalChestLabel";
            this.MagicalChestLabel.Size = new System.Drawing.Size(18, 20);
            this.MagicalChestLabel.TabIndex = 9;
            this.MagicalChestLabel.Text = "0";
            this.MagicalChestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MagicalChestLabel.Click += new System.EventHandler(this.MagicalChestLabel_Click);
            // 
            // NormalChestLabel
            // 
            this.NormalChestLabel.AutoSize = true;
            this.NormalChestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NormalChestLabel.ForeColor = System.Drawing.Color.White;
            this.NormalChestLabel.Location = new System.Drawing.Point(138, 282);
            this.NormalChestLabel.Name = "NormalChestLabel";
            this.NormalChestLabel.Size = new System.Drawing.Size(18, 20);
            this.NormalChestLabel.TabIndex = 8;
            this.NormalChestLabel.Text = "0";
            this.NormalChestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NormalChestLabel.Click += new System.EventHandler(this.NormalChestLabel_Click);
            // 
            // menu2
            // 
            this.menu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.menu2.Controls.Add(this.button4);
            this.menu2.Controls.Add(this.button3);
            this.menu2.Controls.Add(this.AddHomework);
            this.menu2.Controls.Add(this.DataGrid);
            this.menu2.Location = new System.Drawing.Point(95, 56);
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(564, 326);
            this.menu2.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(442, 45);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 32);
            this.button4.TabIndex = 15;
            this.button4.Text = "✓";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
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
            this.button3.Click += new System.EventHandler(this.Button3_Click);
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
            // SettingsMenu
            // 
            this.SettingsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.SettingsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsMenu.ForeColor = System.Drawing.Color.White;
            this.SettingsMenu.Image = global::Adventure_book.Properties.Resources.gearBlue;
            this.SettingsMenu.Location = new System.Drawing.Point(12, 305);
            this.SettingsMenu.Name = "SettingsMenu";
            this.SettingsMenu.Size = new System.Drawing.Size(77, 77);
            this.SettingsMenu.TabIndex = 6;
            this.SettingsMenu.UseVisualStyleBackColor = false;
            this.SettingsMenu.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Character
            // 
            this.Character.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Character.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Character.ForeColor = System.Drawing.Color.White;
            this.Character.Image = global::Adventure_book.Properties.Resources.userBlue;
            this.Character.Location = new System.Drawing.Point(12, 222);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(77, 77);
            this.Character.TabIndex = 5;
            this.Character.UseVisualStyleBackColor = false;
            this.Character.Click += new System.EventHandler(this.Character_Click);
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calendar.ForeColor = System.Drawing.Color.White;
            this.Calendar.Image = global::Adventure_book.Properties.Resources.calendarBlue;
            this.Calendar.Location = new System.Drawing.Point(12, 139);
            this.Calendar.Name = "Calendar";
            this.Calendar.Size = new System.Drawing.Size(77, 77);
            this.Calendar.TabIndex = 4;
            this.Calendar.UseVisualStyleBackColor = false;
            this.Calendar.Click += new System.EventHandler(this.Calendar_Click);
            // 
            // Chestroom
            // 
            this.Chestroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Chestroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chestroom.ForeColor = System.Drawing.Color.White;
            this.Chestroom.Image = global::Adventure_book.Properties.Resources.chestBlue;
            this.Chestroom.Location = new System.Drawing.Point(12, 56);
            this.Chestroom.Name = "Chestroom";
            this.Chestroom.Size = new System.Drawing.Size(77, 77);
            this.Chestroom.TabIndex = 3;
            this.Chestroom.UseVisualStyleBackColor = false;
            this.Chestroom.Click += new System.EventHandler(this.Chestroom_Click);
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
            this.whiteMode.CheckedChanged += new System.EventHandler(this.LightMode_CheckedChanged);
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
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(671, 395);
            this.ControlBox = false;
            this.Controls.Add(this.SettingsMenu);
            this.Controls.Add(this.Character);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.Chestroom);
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
            ((System.ComponentModel.ISupportInitialize)(this.NormalChest)).EndInit();
            this.menu2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.menu4.ResumeLayout(false);
            this.menu4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel menu1;
        public System.Windows.Forms.Button MinimizeButton;
        public System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Chestroom;
        public System.Windows.Forms.Button Calendar;
        public System.Windows.Forms.Button Character;
        public System.Windows.Forms.Label MagicalChestLabel;
        public System.Windows.Forms.Label NormalChestLabel;
        public System.Windows.Forms.Button SettingsMenu;
        protected System.Windows.Forms.PictureBox NormalChest;
        public System.Windows.Forms.PictureBox magicalChest;
        public System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Panel menu2;
        private System.Windows.Forms.Panel menu3;
        private System.Windows.Forms.Panel menu4;
        public System.Windows.Forms.Button AddHomework;
        public System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Coins;
        public System.Windows.Forms.Label CoinsLabel;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox whiteMode;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button button4;
    }
}

