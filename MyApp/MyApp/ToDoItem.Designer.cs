
namespace MyApp
{
    partial class ToDoItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoItem));
            this.DeletePB = new System.Windows.Forms.PictureBox();
            this.ApplyPB = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackUpPB = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewTaskTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DeletePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackUpPB)).BeginInit();
            this.SuspendLayout();
            // 
            // DeletePB
            // 
            this.DeletePB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeletePB.Image = ((System.Drawing.Image)(resources.GetObject("DeletePB.Image")));
            this.DeletePB.Location = new System.Drawing.Point(768, 7);
            this.DeletePB.Name = "DeletePB";
            this.DeletePB.Size = new System.Drawing.Size(50, 50);
            this.DeletePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeletePB.TabIndex = 0;
            this.DeletePB.TabStop = false;
            this.DeletePB.Click += new System.EventHandler(this.DeletePB_Click);
            // 
            // ApplyPB
            // 
            this.ApplyPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApplyPB.Image = ((System.Drawing.Image)(resources.GetObject("ApplyPB.Image")));
            this.ApplyPB.Location = new System.Drawing.Point(651, 7);
            this.ApplyPB.Name = "ApplyPB";
            this.ApplyPB.Size = new System.Drawing.Size(50, 50);
            this.ApplyPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ApplyPB.TabIndex = 1;
            this.ApplyPB.TabStop = false;
            this.ApplyPB.Visible = false;
            this.ApplyPB.Click += new System.EventHandler(this.ApplyPB_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(713, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // BackUpPB
            // 
            this.BackUpPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackUpPB.Image = ((System.Drawing.Image)(resources.GetObject("BackUpPB.Image")));
            this.BackUpPB.Location = new System.Drawing.Point(768, 7);
            this.BackUpPB.Name = "BackUpPB";
            this.BackUpPB.Size = new System.Drawing.Size(50, 50);
            this.BackUpPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackUpPB.TabIndex = 3;
            this.BackUpPB.TabStop = false;
            this.BackUpPB.Visible = false;
            this.BackUpPB.Click += new System.EventHandler(this.BackUpPB_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(25, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 2);
            this.panel1.TabIndex = 4;
            // 
            // NewTaskTB
            // 
            this.NewTaskTB.BackColor = System.Drawing.Color.RoyalBlue;
            this.NewTaskTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewTaskTB.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewTaskTB.ForeColor = System.Drawing.Color.White;
            this.NewTaskTB.Location = new System.Drawing.Point(25, 12);
            this.NewTaskTB.Name = "NewTaskTB";
            this.NewTaskTB.Size = new System.Drawing.Size(592, 30);
            this.NewTaskTB.TabIndex = 5;
            this.NewTaskTB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // ToDoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewTaskTB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackUpPB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ApplyPB);
            this.Controls.Add(this.DeletePB);
            this.Name = "ToDoItem";
            this.Size = new System.Drawing.Size(830, 64);
            ((System.ComponentModel.ISupportInitialize)(this.DeletePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackUpPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DeletePB;
        private System.Windows.Forms.PictureBox ApplyPB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BackUpPB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NewTaskTB;
        private System.Windows.Forms.Label label1;
    }
}
