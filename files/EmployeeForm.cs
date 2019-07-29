
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Diagnostics;

namespace files
{
    public partial class EmployeeForm : Form
    {
        string log_in;
        string picPath;
        String current_project;
        XmlNodeList child_project;
        public EmployeeForm()
        {
            InitializeComponent();
            timer1.Start();
            load();
            load_download();
        }
        public EmployeeForm(string log_in)
        {
            InitializeComponent();
            timer1.Start();
            this.log_in = log_in;
            load();
            load_download();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }
        public void load()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("user.xml");
            XmlNodeList employee = doc.GetElementsByTagName("Employee");
            for (int i = 0; i < employee.Count; i++)
            {
                XmlNodeList child = employee[i].ChildNodes;
                string name = child[0].InnerText;
                if (name == log_in)
                {
                    current_project = child[3].InnerText;
                    load_project(current_project);
                    break;
                }
            }
            lblname.Text = "Welcom !"+log_in;
        }
        public void load_project(string cp)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("user.xml");
            XmlNodeList Employees = doc.GetElementsByTagName("Employee");
            txtproject_name.Text = cp;
            for (int i = 0; i < Employees.Count; i++)
            {
                XmlNodeList child = Employees[i].ChildNodes;
                if (child[3].InnerText == cp)
                {
                    if (child[0].InnerText != log_in)
                    {
                        combocemployee.Items.Add(child[0].InnerText);
                    }
                }
            }
            XmlDocument doc_task = new XmlDocument();
            doc_task.Load("project.xml");
            XmlNodeList task = doc_task.GetElementsByTagName("Task");
            for(int i=0;i<task.Count;i++)
            {
                XmlNodeList child = task[i].ChildNodes;
                if (child[1].InnerText==log_in)
                {
                    comtasks.Items.Add(child[0].InnerText);
                }

            }

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("project.xml");
            XmlNodeList projects = doc.GetElementsByTagName("project");
            txtattach_file.Text = picPath;
            for (int i = 0; i < projects.Count; i++)
            {
                XmlNodeList project = projects[i].ChildNodes;
                XmlNodeList tasks = project[3].ChildNodes;
                if (project[1].InnerText == "unfinished")
                {
                    for (int j = 0; j < tasks.Count; j++)
                    {
                        XmlNodeList task = tasks[i].ChildNodes;
                        if (task[1].InnerText == log_in &&task[8].InnerText=="true")
                        {
                            Process.Start(task[5].InnerText);
                            task[8].InnerText = "false";
                        }
                    }
                }
            }
            doc.Save("project.xml");
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                picPath = dlg.FileName.ToString();
            }
            if (picPath != "")
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("project.xml");
                XmlNodeList projects = doc.GetElementsByTagName("project");
                txtattach_file.Text = picPath;
                    for (int i = 0; i < projects.Count; i++)
                    {
                        XmlNodeList project = projects[i].ChildNodes;
                        XmlNodeList tasks = project[3].ChildNodes;
                        if (project[1].InnerText == "unfinished")
                        {
                            for (int j = 0; j < tasks.Count; j++)
                            {
                                XmlNodeList task = tasks[j].ChildNodes;
                                if (task[1].InnerText == log_in)
                                {
                                    task[5].InnerText = picPath;
                                    break;
                                }
                            }
                        }
                    }
                    MessageBox.Show("Complete");
                    doc.Save("project.xml");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtComment.Text == "")
                MessageBox.Show("Please Comment");
            else
            {
                string forward = Convert.ToString(combocemployee.SelectedItem);
                XmlDocument doc = new XmlDocument();
                doc.Load("project.xml");
                XmlNodeList projects = doc.GetElementsByTagName("project");
                txtattach_file.Text = picPath;
                for (int i = 0; i < projects.Count; i++)
                {
                    XmlNodeList project = projects[i].ChildNodes;
                    XmlNodeList tasks = project[3].ChildNodes;
                    if (project[1].InnerText == "unfinished")
                    {
                        for (int j = 0; j < tasks.Count; j++)
                        {
                            XmlNodeList task = tasks[j].ChildNodes;
                            if (task[1].InnerText == log_in && task[0].InnerText == comtasks.SelectedItem.ToString())
                            {
                                task[1].InnerText = forward;
                                task[3].InnerText = txtComment.Text;
                                task[8].InnerText = "true";

                                break;
                            }
                        }
                    }
                }
                MessageBox.Show("Complete");
                doc.Save("project.xml");
            }
        }

        public void load_download()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("project.xml");
            XmlNodeList tasks = doc.GetElementsByTagName("Task");
            for (int i = 0; i < tasks.Count; i++)
            {
                XmlNodeList child_task = tasks[i].ChildNodes;
                if (child_task[1].InnerText ==log_in)
                {
                    if (child_task[8].InnerText == "true")
                    {
                        button3.Enabled=true;
                    }
                }
            }
        }

        private void comtasks_SelectedIndexChanged(object sender, EventArgs e)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("project.xml");
            XmlNodeList tasks = doc.GetElementsByTagName("Task");
            for (int i = 0; i < tasks.Count; i++)
            {
                XmlNodeList child_task = tasks[i].ChildNodes;
                if (child_task[0].InnerText == this.comtasks.SelectedItem.ToString())
                {
                    txtdescription.Text = child_task[2].InnerText;
                    break;
                }
            }
        }
    }
}
