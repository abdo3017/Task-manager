using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace files
{
    public partial class Uc_chose : UserControl
    {
        public Uc_chose()
        {
            InitializeComponent();
        }

     
        private void btn_Admin_Click_1(object sender, EventArgs e)
        {
            ((LohinForm)this.FindForm()).Btn_Back.Visible = true;
            Control US = this.Parent; //this 
            US.Controls.Clear();
            UC_Admin a = new UC_Admin();
            US.Controls.Add(a);
            a.Dock = DockStyle.Fill;
        }

        private void btn_Employee_Click_1(object sender, EventArgs e)
        {
            ((LohinForm)this.FindForm()).Btn_Back.Visible = true;
            Control US = this.Parent;
                US.Controls.Clear();
                UC_Employee em = new UC_Employee();
                US.Controls.Add(em);
                em.Dock = DockStyle.Fill;
            
        }
    }
}
