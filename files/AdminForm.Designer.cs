namespace files
{
	partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnCheakUploadedProjects = new System.Windows.Forms.Button();
            this.btn_CheackTasks = new System.Windows.Forms.Button();
            this.btn_CheakMem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.PanelAdmin = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLeft.Controls.Add(this.btn_home);
            this.panelLeft.Controls.Add(this.SidePanel);
            this.panelLeft.Controls.Add(this.btnCheakUploadedProjects);
            this.panelLeft.Controls.Add(this.btn_CheackTasks);
            this.panelLeft.Controls.Add(this.btn_CheakMem);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(353, 886);
            this.panelLeft.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SidePanel.Location = new System.Drawing.Point(4, 273);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 74);
            this.SidePanel.TabIndex = 2;
            // 
            // btnCheakUploadedProjects
            // 
            this.btnCheakUploadedProjects.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheakUploadedProjects.FlatAppearance.BorderSize = 0;
            this.btnCheakUploadedProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheakUploadedProjects.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheakUploadedProjects.ForeColor = System.Drawing.Color.Teal;
            this.btnCheakUploadedProjects.Image = global::files.Properties.Resources.icons8_groups_filled_50px_111;
            this.btnCheakUploadedProjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheakUploadedProjects.Location = new System.Drawing.Point(20, 367);
            this.btnCheakUploadedProjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheakUploadedProjects.Name = "btnCheakUploadedProjects";
            this.btnCheakUploadedProjects.Size = new System.Drawing.Size(333, 74);
            this.btnCheakUploadedProjects.TabIndex = 6;
            this.btnCheakUploadedProjects.Text = "             Create / Check    Projects";
            this.btnCheakUploadedProjects.UseVisualStyleBackColor = false;
            this.btnCheakUploadedProjects.Click += new System.EventHandler(this.btnCheakUploadedProjects_Click);
            // 
            // btn_CheackTasks
            // 
            this.btn_CheackTasks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_CheackTasks.FlatAppearance.BorderSize = 0;
            this.btn_CheackTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CheackTasks.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheackTasks.ForeColor = System.Drawing.Color.Teal;
            this.btn_CheackTasks.Image = ((System.Drawing.Image)(resources.GetObject("btn_CheackTasks.Image")));
            this.btn_CheackTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CheackTasks.Location = new System.Drawing.Point(20, 462);
            this.btn_CheackTasks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CheackTasks.Name = "btn_CheackTasks";
            this.btn_CheackTasks.Size = new System.Drawing.Size(333, 74);
            this.btn_CheackTasks.TabIndex = 5;
            this.btn_CheackTasks.Text = "       Give / Check\r\nTasks";
            this.btn_CheackTasks.UseVisualStyleBackColor = false;
            this.btn_CheackTasks.Click += new System.EventHandler(this.btn_CheackTasks_Click);
            // 
            // btn_CheakMem
            // 
            this.btn_CheakMem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_CheakMem.FlatAppearance.BorderSize = 0;
            this.btn_CheakMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CheakMem.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheakMem.ForeColor = System.Drawing.Color.Teal;
            this.btn_CheakMem.Image = ((System.Drawing.Image)(resources.GetObject("btn_CheakMem.Image")));
            this.btn_CheakMem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CheakMem.Location = new System.Drawing.Point(20, 271);
            this.btn_CheakMem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CheakMem.Name = "btn_CheakMem";
            this.btn_CheakMem.Size = new System.Drawing.Size(333, 74);
            this.btn_CheakMem.TabIndex = 2;
            this.btn_CheakMem.Text = "                   Create / Check               Employee\r\n\r\n";
            this.btn_CheakMem.UseVisualStyleBackColor = false;
            this.btn_CheakMem.Click += new System.EventHandler(this.btn_CheakMem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btn_menu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 49);
            this.panel2.TabIndex = 1;
            // 
            // btn_menu
            // 
            this.btn_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu.Location = new System.Drawing.Point(281, -6);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(68, 64);
            this.btn_menu.TabIndex = 3;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin DashBoard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.labelTime);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btn_close);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(353, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1247, 49);
            this.panel3.TabIndex = 1;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(1043, 10);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(121, 29);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "HH:MM:SS";
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(1179, -9);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(68, 64);
            this.btn_close.TabIndex = 4;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // PanelAdmin
            // 
            this.PanelAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAdmin.Location = new System.Drawing.Point(353, 49);
            this.PanelAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelAdmin.Name = "PanelAdmin";
            this.PanelAdmin.Size = new System.Drawing.Size(1247, 837);
            this.PanelAdmin.TabIndex = 2;
            this.PanelAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelAdmin_Paint);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.Teal;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(20, 189);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(333, 74);
            this.btn_home.TabIndex = 7;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 886);
            this.Controls.Add(this.PanelAdmin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelLeft;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnCheakUploadedProjects;
		private System.Windows.Forms.Button btn_CheackTasks;
		private System.Windows.Forms.Button btn_CheakMem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btn_menu;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timerTime;
		private System.Windows.Forms.Panel PanelAdmin;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btn_home;
    }
}