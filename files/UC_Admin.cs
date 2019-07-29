using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
namespace files
{
    public partial class UC_Admin : UserControl
    {
        public UC_Admin()
        {
            InitializeComponent();
        }

  

        private void btn_Login_admin_Click_1(object sender, EventArgs e)
        {
            AdminForm fd = new AdminForm();
            fd.ShowDialog();

            Control UC = this.Parent;
            UC.Controls.Clear();
            Uc_chose c = new Uc_chose();
            UC.Controls.Add(c);
            c.Dock = DockStyle.Fill;
        }

        private void UC_Admin_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_admin_Click(object sender, EventArgs e)
        {
           
            XmlDocument docEmp = new XmlDocument();
            docEmp.Load("user.xml");
            XmlNodeList Admin = docEmp.GetElementsByTagName("Admin");
            for (int i = 0; i < Admin.Count; i++)
            {
                XmlNodeList Employeechilds = Admin[i].ChildNodes;
                if (Employeechilds[0].InnerText == txt_userName.Text.ToString() && Employeechilds[1].InnerText == txt_pass.Text.ToString())
                {
                    ((LohinForm)this.FindForm()).Btn_Back.Visible = false;
                    AdminForm fd = new AdminForm();
                    fd.ShowDialog();
                    Control UC = this.Parent;
                    UC.Controls.Clear();
                    Uc_chose c = new Uc_chose();
                    UC.Controls.Add(c);
                    c.Dock = DockStyle.Fill;
                }
                else
                    MessageBox.Show("Your Entered Wrong Password Or Username");
            }
        }
    }
}
