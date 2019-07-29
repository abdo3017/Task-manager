using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
namespace files
{
	public partial class LohinForm : Form
	{

        Uc_chose c = new Uc_chose();
        public LohinForm()
		{
			InitializeComponent();
            Call_Main();
            Call_Loading_UC();
        }
        public void Call_Main()

        {

            //this.Controls.Remove(l);
            this.Size = new Size(446, 562);
            this.US1.Visible = true;
            Lbl__Titel.Text = "Task Management System";
            Btn_Exit.Location = new Point(398, -4);

            US1.Controls.Clear();
            US1.Controls.Add(c);
            c.Dock = DockStyle.Fill;
        }
        public void Call_Loading_UC()
        {

            Form_loading l = new Form_loading();
            l.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.US1.Controls.Clear();
            US1.Controls.Add(c);
            c.Dock = DockStyle.Fill;
            this.Btn_Back.Visible = false;

        }
    }
}
