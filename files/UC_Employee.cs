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
    public partial class UC_Employee : UserControl
    {
        public UC_Employee()
        {
            InitializeComponent();
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            Control US = this.Parent;
            US.Controls.Clear();
            Register R = new Register();
            US.Controls.Add(R);
            R.Dock = DockStyle.Fill;

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_employee_Click_1(object sender, EventArgs e)
        {
            bool found = false;
            XmlDocument docEmp = new XmlDocument();
            docEmp.Load("user.xml");
            XmlNodeList EmployeeList = docEmp.GetElementsByTagName("Employee");
            for (int i = 0; i < EmployeeList.Count; i++)
            {
                XmlNodeList Employeechilds = EmployeeList[i].ChildNodes;
                if (Employeechilds[0].InnerText == txt_userName.Text.ToString() && Employeechilds[2].InnerText==txt_pass.Text.ToString())
                {
                    ((LohinForm)this.FindForm()).Btn_Back.Visible = false;
                    EmployeeForm E = new EmployeeForm(Employeechilds[0].InnerText);
                    E.ShowDialog();
                    found = true;
                    break;
                }
               
            }
            if (found == false)
                MessageBox.Show("Your Entered Wrong Password Or Username");


        }
    }
}
