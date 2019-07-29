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
    public partial class UC_HomeAdmin : UserControl
    {
        public UC_HomeAdmin()
        {
            InitializeComponent();
            load();
        }
       public void load()
        {

            XmlDocument docUser = new XmlDocument();
            docUser.Load("user.xml");
            XmlNodeList EmployeeList = docUser.GetElementsByTagName("Employee");
            lbl_MembersNum.Text = EmployeeList.Count.ToString();

            XmlNodeList AdminList = docUser.GetElementsByTagName("Admin");
            lbl_AdminsNum.Text = AdminList.Count.ToString();

            XmlDocument docProject = new XmlDocument();
            docProject.Load("project.xml");
           
            XmlNodeList projectNamelist = docProject.GetElementsByTagName("project");
            lbl_ProjectsNum.Text = projectNamelist.Count.ToString();

        }

    }
}
