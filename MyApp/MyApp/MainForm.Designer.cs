
using MyApp;

namespace Book_Shop
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.todoBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monthTimeLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.homeControll1 = new Book_Shop.HomeControll();
            this.helpUserControll1 = new Book_Shop.HelpUserControll();
            this.toDoControll11 = new MyApp.ToDoControll1();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.HelpBtn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.todoBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 729);
            this.panel1.TabIndex = 7;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 686);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(240, 40);
            this.logoutBtn.TabIndex = 10;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Sienna;
            this.SidePanel.Location = new System.Drawing.Point(232, 186);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(12, 62);
            this.SidePanel.TabIndex = 9;
            // 
            // HelpBtn
            // 
            this.HelpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpBtn.FlatAppearance.BorderSize = 0;
            this.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HelpBtn.ForeColor = System.Drawing.Color.White;
            this.HelpBtn.Image = ((System.Drawing.Image)(resources.GetObject("HelpBtn.Image")));
            this.HelpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpBtn.Location = new System.Drawing.Point(0, 390);
            this.HelpBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(240, 61);
            this.HelpBtn.TabIndex = 4;
            this.HelpBtn.Text = "Help";
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 322);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "Donate";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // todoBtn
            // 
            this.todoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.todoBtn.FlatAppearance.BorderSize = 0;
            this.todoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todoBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.todoBtn.ForeColor = System.Drawing.Color.White;
            this.todoBtn.Image = ((System.Drawing.Image)(resources.GetObject("todoBtn.Image")));
            this.todoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.todoBtn.Location = new System.Drawing.Point(0, 254);
            this.todoBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.todoBtn.Name = "todoBtn";
            this.todoBtn.Size = new System.Drawing.Size(240, 61);
            this.todoBtn.TabIndex = 2;
            this.todoBtn.Text = "To-Do";
            this.todoBtn.UseVisualStyleBackColor = true;
            this.todoBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.UsernameLbl);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 185);
            this.panel3.TabIndex = 1;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLbl.ForeColor = System.Drawing.Color.White;
            this.UsernameLbl.Location = new System.Drawing.Point(75, 117);
            this.UsernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(138, 23);
            this.UsernameLbl.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.Location = new System.Drawing.Point(0, 186);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(240, 61);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.monthTimeLbl);
            this.panel2.Controls.Add(this.timeLbl);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(244, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 74);
            this.panel2.TabIndex = 8;
            // 
            // monthTimeLbl
            // 
            this.monthTimeLbl.AutoSize = true;
            this.monthTimeLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthTimeLbl.ForeColor = System.Drawing.Color.White;
            this.monthTimeLbl.Location = new System.Drawing.Point(331, 28);
            this.monthTimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.monthTimeLbl.Name = "monthTimeLbl";
            this.monthTimeLbl.Size = new System.Drawing.Size(65, 22);
            this.monthTimeLbl.TabIndex = 6;
            this.monthTimeLbl.Text = "label2";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLbl.ForeColor = System.Drawing.Color.White;
            this.timeLbl.Location = new System.Drawing.Point(590, 27);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(65, 22);
            this.timeLbl.TabIndex = 5;
            this.timeLbl.Text = "label2";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(786, 16);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 57);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Facebook";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.toDoControll11);
            this.panel4.Controls.Add(this.homeControll1);
            this.panel4.Controls.Add(this.helpUserControll1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(244, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(847, 655);
            this.panel4.TabIndex = 9;
            // 
            // homeControll1
            // 
            this.homeControll1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeControll1.Location = new System.Drawing.Point(0, 0);
            this.homeControll1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.homeControll1.Name = "homeControll1";
            this.homeControll1.Size = new System.Drawing.Size(847, 655);
            this.homeControll1.TabIndex = 2;
            // 
            // helpUserControll1
            // 
            this.helpUserControll1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpUserControll1.Location = new System.Drawing.Point(0, 0);
            this.helpUserControll1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.helpUserControll1.Name = "helpUserControll1";
            this.helpUserControll1.Size = new System.Drawing.Size(847, 655);
            this.helpUserControll1.TabIndex = 1;
            // 
            // toDoControll11
            // 
            this.toDoControll11.Location = new System.Drawing.Point(0, 0);
            this.toDoControll11.Name = "toDoControll11";
            this.toDoControll11.Size = new System.Drawing.Size(847, 655);
            this.toDoControll11.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 729);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button todoBtn;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label monthTimeLbl;
        private System.Windows.Forms.Panel panel4;
        private HomeControll homeControll1;
        private HelpUserControll helpUserControll1;
        private System.Windows.Forms.Button logoutBtn;
        private ToDoControll1 toDoControll11;
    }
}