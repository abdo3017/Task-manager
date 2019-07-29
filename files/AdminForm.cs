using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace files
{
	public partial class AdminForm : Form
	{
        public bool editTaskPressed = false;
        public bool editEmpPressed = false;
        public string projectName;
        int panelWidth;
		bool isCollapsed;
		public AdminForm()
		{
			// to move the panel in the left 
			InitializeComponent();
			timerTime.Start();
			panelWidth = panelLeft.Width;
			isCollapsed = false;
			//end of moving 


			PanelAdmin.Controls.Clear();
			UC_HomeAdmin ha = new UC_HomeAdmin();
			PanelAdmin.Controls.Add(ha);
			ha.Dock = DockStyle.Fill;


		}

		private void button2_Click(object sender, EventArgs e)
		{
			//MoveSidePanel(btn_CheackAdmin);

			PanelAdmin.Controls.Clear();
			UC_CreateORChekAdmin c = new UC_CreateORChekAdmin();
			PanelAdmin.Controls.Add(c);
			c.Dock = DockStyle.Fill;


		}

		private void AdminForm_Load(object sender, EventArgs e)
		{

		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if(isCollapsed)
			{
				panelLeft.Width = panelLeft.Width + 10;
				if (panelLeft.Width >= panelWidth)
				{
					timer1.Stop();
					isCollapsed = false;
					this.Refresh();
				}
			}
			else
			{
				panelLeft.Width = panelLeft.Width - 10;
				if (panelLeft.Width <= 75)
				{
					timer1.Stop();
					isCollapsed = true;
					this.Refresh();
				}
			}

		}

		private void btn_menu_Click(object sender, EventArgs e)
		{
			timer1.Start();
		}
		private void MoveSidePanel(Control btn)
		{
			SidePanel.Top = btn.Top;
			SidePanel.Height = btn.Height;
		}

		public void btn_CheakMem_Click(object sender, EventArgs e)
		{
			MoveSidePanel(btn_CheakMem);
            UC_Createmember c;
            if (editEmpPressed)
            {
                editEmpPressed = false;
                c = new UC_Createmember(projectName);
            }
            else
                c = new UC_Createmember();

            PanelAdmin.Controls.Clear();
			PanelAdmin.Controls.Add(c);
			c.Dock = DockStyle.Fill;
		}

	

		public void btn_CheackTasks_Click(object sender, EventArgs e)
		{
			MoveSidePanel(btn_CheackTasks);
            UC_GiveTasks g;
            if (editTaskPressed)
            {
                editTaskPressed = false;
                g = new UC_GiveTasks(projectName);
            }
            else
                g = new UC_GiveTasks();
            PanelAdmin.Controls.Clear();
			PanelAdmin.Controls.Add(g);
			g.Dock = DockStyle.Fill;



		}

		private void btnCheakUploadedProjects_Click(object sender, EventArgs e)
		{
			MoveSidePanel(btnCheakUploadedProjects);

			PanelAdmin.Controls.Clear();
			UC_UploadedProjects up = new UC_UploadedProjects();
			PanelAdmin.Controls.Add(up);
			up.Dock = DockStyle.Fill;
		}

		private void timerTime_Tick(object sender, EventArgs e)
		{
			DateTime dt = DateTime.Now;
			labelTime.Text = dt.ToString("HH:MM:ss");

		}

        private void PanelAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btn_home);
            PanelAdmin.Controls.Clear();
            UC_HomeAdmin ha = new UC_HomeAdmin();
            PanelAdmin.Controls.Add(ha);
            ha.Dock = DockStyle.Fill;


        }
    }
}
