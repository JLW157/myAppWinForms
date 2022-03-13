
namespace MyApp
{
    partial class ToDoControll1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoControll1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TaskTB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AddTaskPB = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddTaskPB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "To-Do list for today:";
            // 
            // TaskTB
            // 
            this.TaskTB.BackColor = System.Drawing.SystemColors.Control;
            this.TaskTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskTB.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaskTB.Location = new System.Drawing.Point(45, 40);
            this.TaskTB.Name = "TaskTB";
            this.TaskTB.Size = new System.Drawing.Size(661, 30);
            this.TaskTB.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.AddTaskPB);
            this.panel2.Controls.Add(this.TaskTB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 555);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 100);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(45, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(661, 3);
            this.panel4.TabIndex = 3;
            // 
            // AddTaskPB
            // 
            this.AddTaskPB.Image = ((System.Drawing.Image)(resources.GetObject("AddTaskPB.Image")));
            this.AddTaskPB.Location = new System.Drawing.Point(742, 24);
            this.AddTaskPB.Name = "AddTaskPB";
            this.AddTaskPB.Size = new System.Drawing.Size(64, 64);
            this.AddTaskPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddTaskPB.TabIndex = 2;
            this.AddTaskPB.TabStop = false;
            this.AddTaskPB.Click += new System.EventHandler(this.AddTaskPB_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(847, 473);
            this.panel3.TabIndex = 3;
            // 
            // ToDoControll1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ToDoControll1";
            this.Size = new System.Drawing.Size(847, 655);
            this.Load += new System.EventHandler(this.ToDoControll1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddTaskPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TaskTB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox AddTaskPB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
    }
}
