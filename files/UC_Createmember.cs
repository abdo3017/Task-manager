using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Collections;
namespace files
{
    public partial class UC_Createmember : UserControl
    {
        string projectid;
        DataGridViewRow row = null;
        XmlNodeList employee;
        public UC_Createmember()
        {
            InitializeComponent();
            Load();
        }

        public UC_Createmember(string projectid)
        {
            InitializeComponent();
            this.projectid = projectid;
            showRecivedEmployee();

        }
        private void set_text()
        {
            txt_userName.Text = "";
            Txt_Name.Text = "";
            txt_pass.Text = "";
            txt_address.Text = "";
            txt_email.Text = "";
            txt_phone.Text = "";
            Cb_Group.Text = "";
        }
        private void showRecivedEmployee()
        {
            XmlDocument docTask = new XmlDocument();
            docTask.Load("project.xml");

            XmlNodeList projectNamelist = docTask.GetElementsByTagName("Name");
            for (int i = 0; i < projectNamelist.Count; i++)
            {
                Cb_Group.Items.Add(projectNamelist[i].InnerText);
            }
            XmlDocument docEmp = new XmlDocument();
            docEmp.Load("user.xml");
             projectNamelist = docEmp.GetElementsByTagName("currentProject");

             docTask = new XmlDocument();
            docTask.Load("project.xml");
            XmlNodeList tasklist = docTask.GetElementsByTagName("Task");
            for (int i = 0; i < projectNamelist.Count; i++)
            {
                int index = GR_AllEmployees.Rows.Add();
                DataGridViewComboBoxCell b = (DataGridViewComboBoxCell)GR_AllEmployees.Rows[index].Cells[7];
                if (projectNamelist[i].InnerText == projectid)
                {
                    XmlNodeList employee = projectNamelist[i].ParentNode.ChildNodes;
                    GR_AllEmployees.Rows[index].Cells[0].Value = employee[0].InnerText;
                    GR_AllEmployees.Rows[index].Cells[1].Value = employee[1].InnerText;
                    GR_AllEmployees.Rows[index].Cells[2].Value = employee[2].InnerText;
                    GR_AllEmployees.Rows[index].Cells[3].Value = employee[3].InnerText;
                    GR_AllEmployees.Rows[index].Cells[4].Value = employee[4].InnerText;
                    GR_AllEmployees.Rows[index].Cells[5].Value = employee[5].InnerText;
                    GR_AllEmployees.Rows[index].Cells[6].Value = employee[6].InnerText;

                    for (int j = 0; j < tasklist.Count; j++)
                    {
                        XmlNodeList task = tasklist[j].ChildNodes;
                        if (task[1].InnerText == employee[0].InnerText)
                            b.Items.Add(task[0].InnerText);
                    }
                }
            }
        }

        private void Btn_AddNew_Click(object sender, EventArgs e)
        {
            if (txt_address.Text == "" || txt_email.Text == "" || Txt_Name.Text == "" || txt_pass.Text == "" || txt_phone.Text == "" || txt_userName.Text == "")
            {

                MessageBox.Show("Please fill all fields :)");
            }
            else
            {
                string ID = null;
                XmlDocument doc = new XmlDocument();
                XmlElement Employee = doc.CreateElement("Employee");
                XmlElement node = doc.CreateElement("userName");
                node.InnerText = txt_userName.Text;
                Employee.AppendChild(node);
                node = doc.CreateElement("Name");
                node.InnerText = Txt_Name.Text;
                Employee.AppendChild(node);
                node = doc.CreateElement("Passward");
                node.InnerText = txt_pass.Text;
                Employee.AppendChild(node);
                node = doc.CreateElement("currentedproject");
                XmlDocument docTask = new XmlDocument();
                docTask.Load("project.xml");
                XmlNodeList projectNamelist = docTask.GetElementsByTagName("project");
                for (int i = 0; i < projectNamelist.Count; i++)
                {
                    XmlNodeList project = projectNamelist[i].ChildNodes;
                    if (project[0].InnerText == Cb_Group.SelectedItem.ToString())
                    {
                        node.InnerText = project[2].InnerText;
                        ID = project[2].InnerText;
                        break;
                    }
                }
                Employee.AppendChild(node);
                node = doc.CreateElement("Adress");
                node.InnerText = txt_address.Text;
                Employee.AppendChild(node);
                node = doc.CreateElement("Email");
                node.InnerText = txt_email.Text;
                Employee.AppendChild(node);
                node = doc.CreateElement("Phone");
                node.InnerText = txt_phone.Text;
                Employee.AppendChild(node);
                doc.Load("user.xml");
                XmlElement root = doc.DocumentElement;
                root.AppendChild(Employee);
                doc.Save("user.xml");
                GR_AllEmployees.Rows.Add(txt_userName.Text, Txt_Name.Text, txt_pass.Text, ID.ToString(), txt_address.Text, txt_email.Text, txt_phone.Text);
                set_text();
                MessageBox.Show("complete");
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            String user_name = row.Cells["ID"].Value.ToString();
            row.Cells["ID"].Value = txt_userName.Text;
            row.Cells["Name"].Value = Txt_Name.Text;
            row.Cells["Password"].Value = txt_pass.Text;
            row.Cells["Address"].Value = txt_address.Text;
            row.Cells["Email"].Value = txt_email.Text;
            row.Cells["Phone"].Value = txt_phone.Text;
            row.Cells["Group"].Value = Cb_Group.SelectedItem.ToString();
            XmlDocument doc = new XmlDocument();
            doc.Load("user.xml");
            employee = doc.GetElementsByTagName("Employee");
            for (int i = 0; i < employee.Count; i++)
            {
                XmlNodeList child = employee[i].ChildNodes;
                if (child[0].InnerText == user_name)
                {
                    child[0].InnerText = txt_userName.Text;
                    child[1].InnerText = Txt_Name.Text;
                    child[2].InnerText = txt_pass.Text;
                    child[4].InnerText = txt_address.Text;
                    child[5].InnerText = txt_email.Text;
                    child[6].InnerText = txt_phone.Text;
                    XmlDocument docTask = new XmlDocument();
                    docTask.Load("project.xml");
                    XmlNodeList projectNamelist = docTask.GetElementsByTagName("project");
                    for (int j = 0; j < projectNamelist.Count; j++)
                    {
                        XmlNodeList project = projectNamelist[j].ChildNodes;
                        if (project[0].InnerText == Cb_Group.SelectedItem.ToString())
                        {
                            MessageBox.Show(project[0].InnerText + " " +project[2].InnerText);
                            child[3].InnerText = project[2].InnerText;
                            break;
                        }
                    }
                    break;
                }
            }
            doc.Save("user.xml");
            MessageBox.Show("complete");
            set_text();

        }

        public void Load()
        {
            XmlDocument docTask = new XmlDocument();
            docTask.Load("project.xml");

            XmlNodeList projectNamelist = docTask.GetElementsByTagName("Name");
            for (int i = 0; i < projectNamelist.Count; i++)
            {
                Cb_Group.Items.Add(projectNamelist[i].InnerText);
            }
            XmlNodeList employee;
            XmlDocument doc = new XmlDocument();
            doc.Load("user.xml");
            employee = doc.GetElementsByTagName("Employee");
            XmlDocument doc_pro = new XmlDocument();
            doc_pro.Load("project.xml");
            for (int i = 0; i < employee.Count; i++)
            {
                XmlNodeList child = employee[i].ChildNodes;
                if (child[3].InnerText != "In Active")
                {
                    int row = GR_AllEmployees.Rows.Add();
                    DataGridViewComboBoxCell com = new DataGridViewComboBoxCell();
                    GR_AllEmployees.Rows[row].Cells[0].Value = child[0].InnerText;
                    GR_AllEmployees.Rows[row].Cells[1].Value = child[1].InnerText;
                    GR_AllEmployees.Rows[row].Cells[2].Value = child[2].InnerText;
                    GR_AllEmployees.Rows[row].Cells[3].Value = child[3].InnerText;
                    GR_AllEmployees.Rows[row].Cells[4].Value = child[4].InnerText;
                    GR_AllEmployees.Rows[row].Cells[5].Value = child[5].InnerText;
                    GR_AllEmployees.Rows[row].Cells[6].Value = child[6].InnerText;
                    String name = child[0].InnerText;
                    XmlNodeList task = doc_pro.GetElementsByTagName("Task");
                    for (int k = 0; k < task.Count; k++)
                    {
                        XmlNodeList element_task = task[k].ChildNodes;
                        if (element_task[1].InnerText!=null&&element_task[1].InnerText == name) 
                        {
                            com.Items.Add(element_task[0].InnerText);
                        }
                    }
                    GR_AllEmployees.Rows[row].Cells[7] = com;
                }
            }
        }

        private void GR_AllEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 8)
            {

                row = this.GR_AllEmployees.Rows[e.RowIndex];
                txt_userName.Text = row.Cells["ID"].Value.ToString();
                Txt_Name.Text = row.Cells["Name"].Value.ToString();
                txt_pass.Text = row.Cells["Password"].Value.ToString();
                txt_address.Text = row.Cells["Address"].Value.ToString();
                txt_email.Text = row.Cells["Email"].Value.ToString();
                txt_phone.Text = row.Cells["Phone"].Value.ToString();
                Cb_Group.Text = row.Cells["Group"].Value.ToString();
                Cb_Group.Text = row.Cells["Group"].Value.ToString();
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("user.xml");
                employee = doc.GetElementsByTagName("Employee");
                for (int i = 0; i < employee.Count; i++)
                {
                    XmlNodeList child = employee[i].ChildNodes;
                    if (child[3].InnerText == GR_AllEmployees.Rows[e.RowIndex].Cells[3].Value.ToString())
                    {
                       // MessageBox.Show(child[3].InnerText);
                        child[3].InnerText = "In Active";
                        doc.Save("user.xml");
                        break;
                    }
                }
                this.GR_AllEmployees.Rows.RemoveAt(e.RowIndex);
            }
            
        }

        private void Cb_Group_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
