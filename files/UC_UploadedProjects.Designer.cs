namespace files
{
	partial class UC_UploadedProjects
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_UploadedProjects));
            this.GR_ProjectsTasks = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Project_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Members = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Tasks = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Close = new System.Windows.Forms.DataGridViewImageColumn();
            this.Complete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Report = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.GB_newGroup = new System.Windows.Forms.GroupBox();
            this.Btn_AddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.txt_ProjectName = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GR_ProjectsTasks)).BeginInit();
            this.GB_newGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // GR_ProjectsTasks
            // 
            this.GR_ProjectsTasks.AllowUserToAddRows = false;
            this.GR_ProjectsTasks.AllowUserToDeleteRows = false;
            this.GR_ProjectsTasks.AllowUserToOrderColumns = true;
            this.GR_ProjectsTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GR_ProjectsTasks.BackgroundColor = System.Drawing.Color.White;
            this.GR_ProjectsTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GR_ProjectsTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GR_ProjectsTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GR_ProjectsTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GR_ProjectsTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Project_Name,
            this.Members,
            this.Tasks,
            this.Close,
            this.Complete,
            this.Report});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GR_ProjectsTasks.DefaultCellStyle = dataGridViewCellStyle2;
            this.GR_ProjectsTasks.Location = new System.Drawing.Point(3, 82);
            this.GR_ProjectsTasks.MultiSelect = false;
            this.GR_ProjectsTasks.Name = "GR_ProjectsTasks";
            this.GR_ProjectsTasks.RowHeadersVisible = false;
            this.GR_ProjectsTasks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.GR_ProjectsTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GR_ProjectsTasks.Size = new System.Drawing.Size(817, 563);
            this.GR_ProjectsTasks.TabIndex = 0;
            this.GR_ProjectsTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GR_ProjectsTasks_CellClick);
            this.GR_ProjectsTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GR_ProjectsTasks_CellContentClick);
            // 
            // ID
            // 
            this.ID.FillWeight = 35.53299F;
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 30000;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Project_Name
            // 
            this.Project_Name.FillWeight = 124.2587F;
            this.Project_Name.HeaderText = "Project_Name";
            this.Project_Name.Name = "Project_Name";
            this.Project_Name.ReadOnly = true;
            // 
            // Members
            // 
            this.Members.FillWeight = 88.10886F;
            this.Members.HeaderText = "Members";
            this.Members.Name = "Members";
            this.Members.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Members.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Tasks
            // 
            this.Tasks.HeaderText = "Tasks";
            this.Tasks.Name = "Tasks";
            this.Tasks.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tasks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Close
            // 
            this.Close.FillWeight = 113.0248F;
            this.Close.HeaderText = "Close";
            this.Close.Image = global::files.Properties.Resources.Button_Close_icon;
            this.Close.Name = "Close";
            this.Close.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Complete
            // 
            this.Complete.FillWeight = 113.0248F;
            this.Complete.HeaderText = "Complete";
            this.Complete.Image = global::files.Properties.Resources.Done_icon;
            this.Complete.Name = "Complete";
            this.Complete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Report
            // 
            this.Report.HeaderText = "Report";
            this.Report.Name = "Report";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(817, 39);
            this.label5.TabIndex = 30;
            this.label5.Text = "Projects ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GB_newGroup
            // 
            this.GB_newGroup.Controls.Add(this.Btn_AddNew);
            this.GB_newGroup.Controls.Add(this.label1);
            this.GB_newGroup.Controls.Add(this.label3);
            this.GB_newGroup.Controls.Add(this.Btn_Edit);
            this.GB_newGroup.Controls.Add(this.txt_ProjectName);
            this.GB_newGroup.Location = new System.Drawing.Point(837, 40);
            this.GB_newGroup.Name = "GB_newGroup";
            this.GB_newGroup.Size = new System.Drawing.Size(360, 417);
            this.GB_newGroup.TabIndex = 50;
            this.GB_newGroup.TabStop = false;
            // 
            // Btn_AddNew
            // 
            this.Btn_AddNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_AddNew.FlatAppearance.BorderSize = 0;
            this.Btn_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddNew.ForeColor = System.Drawing.Color.White;
            this.Btn_AddNew.Location = new System.Drawing.Point(95, 240);
            this.Btn_AddNew.Name = "Btn_AddNew";
            this.Btn_AddNew.Size = new System.Drawing.Size(195, 35);
            this.Btn_AddNew.TabIndex = 51;
            this.Btn_AddNew.Text = "Add New";
            this.Btn_AddNew.UseVisualStyleBackColor = false;
            this.Btn_AddNew.Click += new System.EventHandler(this.Btn_AddNew_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 49);
            this.label1.TabIndex = 31;
            this.label1.Text = "Add or Edit Projects";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(91, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Project Name";
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Edit.FlatAppearance.BorderSize = 0;
            this.Btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit.ForeColor = System.Drawing.Color.White;
            this.Btn_Edit.Location = new System.Drawing.Point(95, 305);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(195, 35);
            this.Btn_Edit.TabIndex = 48;
            this.Btn_Edit.Text = "Edit";
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // txt_ProjectName
            // 
            this.txt_ProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProjectName.Location = new System.Drawing.Point(95, 151);
            this.txt_ProjectName.Name = "txt_ProjectName";
            this.txt_ProjectName.Size = new System.Drawing.Size(181, 29);
            this.txt_ProjectName.TabIndex = 32;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 113.0248F;
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 109;
            // 
            // UC_UploadedProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GB_newGroup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GR_ProjectsTasks);
            this.Name = "UC_UploadedProjects";
            this.Size = new System.Drawing.Size(1268, 668);
            this.Load += new System.EventHandler(this.UC_UploadedProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GR_ProjectsTasks)).EndInit();
            this.GB_newGroup.ResumeLayout(false);
            this.GB_newGroup.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView GR_ProjectsTasks;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox GB_newGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.TextBox txt_ProjectName;
        private System.Windows.Forms.Button Btn_AddNew;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_Name;
        private System.Windows.Forms.DataGridViewComboBoxColumn Members;
        private System.Windows.Forms.DataGridViewComboBoxColumn Tasks;
        private System.Windows.Forms.DataGridViewImageColumn Close;
        private System.Windows.Forms.DataGridViewImageColumn Complete;
        private System.Windows.Forms.DataGridViewButtonColumn Report;
    }
}
