namespace files
{
    partial class EditprojectForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Task = new System.Windows.Forms.Button();
            this.brn_Emp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which Would You Like to Edit?!";
            // 
            // Btn_Task
            // 
            this.Btn_Task.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Task.FlatAppearance.BorderSize = 0;
            this.Btn_Task.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Task.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Task.ForeColor = System.Drawing.Color.White;
            this.Btn_Task.Location = new System.Drawing.Point(58, 164);
            this.Btn_Task.Name = "Btn_Task";
            this.Btn_Task.Size = new System.Drawing.Size(139, 35);
            this.Btn_Task.TabIndex = 52;
            this.Btn_Task.Text = "Task";
            this.Btn_Task.UseVisualStyleBackColor = false;
            this.Btn_Task.Click += new System.EventHandler(this.Btn_Task_Click);
            // 
            // brn_Emp
            // 
            this.brn_Emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brn_Emp.FlatAppearance.BorderSize = 0;
            this.brn_Emp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brn_Emp.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_Emp.ForeColor = System.Drawing.Color.White;
            this.brn_Emp.Location = new System.Drawing.Point(218, 164);
            this.brn_Emp.Name = "brn_Emp";
            this.brn_Emp.Size = new System.Drawing.Size(139, 35);
            this.brn_Emp.TabIndex = 53;
            this.brn_Emp.Text = "Employee";
            this.brn_Emp.UseVisualStyleBackColor = false;
            this.brn_Emp.Click += new System.EventHandler(this.brn_Emp_Click);
            // 
            // EditprojectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 228);
            this.Controls.Add(this.brn_Emp);
            this.Controls.Add(this.Btn_Task);
            this.Controls.Add(this.label1);
            this.Name = "EditprojectForm";
            this.Text = "EditprojectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Task;
        private System.Windows.Forms.Button brn_Emp;
    }
}