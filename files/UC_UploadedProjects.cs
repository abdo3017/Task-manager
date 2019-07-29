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
using System.IO;

namespace files
{
    public partial class UC_UploadedProjects : UserControl
    {
        string projectid;
        public UC_UploadedProjects()
        {
            InitializeComponent();

        }

        private void UC_UploadedProjects_Load(object sender, EventArgs e)
        {
            XmlDocument docProject = new XmlDocument();
            docProject.Load("project.xml");
            XmlNodeList project = docProject.GetElementsByTagName("project");
            XmlDocument docEmployees = new XmlDocument();
            docEmployees.Load("user.xml");
            XmlNodeList users = docEmployees.GetElementsByTagName("Employee");

            for (int i = 0; i < project.Count; i++)
            {
                XmlNodeList child = project[i].ChildNodes;
                if (child[1].InnerText != "finished")
                {
                    XmlNodeList Tasks = child[3].ChildNodes;
                    var index = GR_ProjectsTasks.Rows.Add();
                    GR_ProjectsTasks.Rows[index].Cells[1].Value = child[0].InnerText;
                    GR_ProjectsTasks.Rows[index].Cells[0].Value = child[2].InnerText;
                    DataGridViewComboBoxCell b = (DataGridViewComboBoxCell)GR_ProjectsTasks.Rows[index].Cells[3];
                        for (int j = 0; j < Tasks.Count; j++)
                        {
                            XmlNodeList name = Tasks[j].ChildNodes;
                            b.Items.Add(name[0].InnerText);
                        }

                        b = (DataGridViewComboBoxCell)GR_ProjectsTasks.Rows[index].Cells[2];
                        for (int j = 0; j < users.Count; j++)
                        {
                            XmlNodeList username = users[j].ChildNodes;
                            if (child[2].InnerText == username[3].InnerText)
                            {
                                b.Items.Add(username[0].InnerText);
                            }
                        }
                    
                }
            }

        }
        int row = 0;
        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_ProjectName.Text == "")
                new EditprojectForm(((AdminForm)this.FindForm()), projectid).Show();
            else if (txt_ProjectName.Text != "")
            {
                XmlDocument docProject = new XmlDocument();
                docProject.Load("project.xml");
                XmlNodeList project = docProject.GetElementsByTagName("project");

                for (int i = 0; i < project.Count; i++)
                {
                    XmlNodeList child = project[i].ChildNodes;
                    if (child[2].InnerText == this.GR_ProjectsTasks.Rows[row].Cells[0].Value.ToString())
                    {
                        
                       
                        this.GR_ProjectsTasks.Rows[row].Cells[1].Value= txt_ProjectName.Text;
                        child[0].InnerText = txt_ProjectName.Text;
                        docProject.Save("project.xml");
                        projectid = this.GR_ProjectsTasks.Rows[row].Cells[0].Value.ToString();
                        ((AdminForm)this.FindForm()).projectName = this.GR_ProjectsTasks.Rows[row].Cells[1].Value.ToString();
                        break;
                    }
                }
                txt_ProjectName.Text = "";

            MessageBox.Show("You edit this project successfully!");
            }
            //else 


        }


        private void GR_ProjectsTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {

                XmlDocument docProject = new XmlDocument();
                docProject.Load("project.xml");
                XmlNodeList project = docProject.GetElementsByTagName("project");

                for (int i = 0; i < project.Count; i++)
                {
                    XmlNodeList child = project[i].ChildNodes;
                    if (child[2].InnerText == this.GR_ProjectsTasks.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        File.Delete("projectreport.xml");
                        XmlWriter writer = XmlWriter.Create("projectreport.xml");
                        writer.WriteStartDocument();
                        writer.WriteStartElement("table");
                        writer.WriteAttributeString("name", "projects");

                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                        writer.Close();

                        XmlDocument xd = new XmlDocument();
                        xd.Load("projectreport.xml");
                        xd.DocumentElement.AppendChild(xd.ImportNode(project[i], true));
                        xd.Save("projectreport.xml");
                        new test().ShowDialog();
                    }
                    else continue;
                }

            }
            else if (e.ColumnIndex == 4 || e.ColumnIndex == 5)
            {
                XmlDocument docProject = new XmlDocument();
                docProject.Load("project.xml");
                XmlNodeList project = docProject.GetElementsByTagName("project");

                for (int i = 0; i < project.Count; i++)
                {
                    XmlNodeList child = project[i].ChildNodes;
                    if (child[2].InnerText == this.GR_ProjectsTasks.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        if(e.ColumnIndex == 4)
                        child[1].InnerText = "finished";
                        else child[1].InnerText = "complete";
                        docProject.Save("project.xml");
                        break;
                    }
                }
                
            }
            row = e.RowIndex;
            projectid = this.GR_ProjectsTasks.Rows[e.RowIndex].Cells[0].Value.ToString();
            ((AdminForm) this.FindForm()).projectName = projectid;
            if (e.ColumnIndex == 4)
                this.GR_ProjectsTasks.Rows.RemoveAt(e.RowIndex);

        }

        private void GR_ProjectsTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_AddNew_Click(object sender, EventArgs e)
        {
            if (txt_ProjectName.Text != "")
            {
                XmlDocument xd = new XmlDocument();
                xd.Load("project.xml");
                int id = xd.GetElementsByTagName("project").Count+1;
                XmlElement project = xd.CreateElement("project");
                XmlElement node = xd.CreateElement("Name");
                node.InnerText = txt_ProjectName.Text;
                project.AppendChild(node);
                node = xd.CreateElement("Status");
                node.InnerText = "unfinished";
                project.AppendChild(node);
                node = xd.CreateElement("Id");
                node.InnerText =id.ToString();
                project.AppendChild(node);
                node = xd.CreateElement("Tasks");
                node.InnerText = "";
                project.AppendChild(node);
                XmlElement root = xd.DocumentElement;
                root.AppendChild(project);
                xd.Save("project.xml");
                var indx = GR_ProjectsTasks.Rows.Add();
                GR_ProjectsTasks.Rows[indx].Cells[0].Value = id.ToString();
                GR_ProjectsTasks.Rows[indx].Cells[1].Value = txt_ProjectName.Text;
                txt_ProjectName.Text = "";
            }
            else
                MessageBox.Show("Invalid Iformation!!");

            MessageBox.Show("You add a new project successfully!!");
        }
    }
}
