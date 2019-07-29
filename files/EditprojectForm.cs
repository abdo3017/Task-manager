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
    public partial class EditprojectForm : Form
    {
        AdminForm f;
        public EditprojectForm(AdminForm f,string s)
        {
            InitializeComponent();
            f.Enabled = false;
            this.f = f;
        }

        private void Btn_Task_Click(object sender, EventArgs e)
        {
            f.Enabled = true;
            f.editTaskPressed = true;
            f.btn_CheackTasks_Click(sender, e);
            this.Close();
        }

        private void brn_Emp_Click(object sender, EventArgs e)
        {
            f.Enabled = true;
            f.editEmpPressed = true;
            f.btn_CheakMem_Click(sender, e);
            this.Close();
        }
    }
}
