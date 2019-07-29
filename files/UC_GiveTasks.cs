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
using System.Diagnostics;

namespace files
{
    public partial class UC_GiveTasks : UserControl
    {
        string thisEmplDownload="";
        string thisEmpltask = "";
        string selected;
        int cellindex, selectedcolumn;
        bool editpressed = false;
        string projectid;
        DataGridViewCellCollection cells;
        public UC_GiveTasks()
        {
            InitializeComponent();
        }

        public UC_GiveTasks(string projectid)
        {
            InitializeComponent();
            this.projectid = projectid;
            editpressed = true;
        }

        private void GiveTasks_Load(object sender, EventArgs e)
        {
            if (!editpressed)
            {
                XmlDocument docTask = new XmlDocument();
                docTask.Load("project.xml");

                XmlNodeList projectNamelist = docTask.GetElementsByTagName("Name");
                for (int i = 0; i < projectNamelist.Count; i++)
                {
                    Cb_SelectGroup.Items.Add(projectNamelist[i].InnerText);
                }
                showInfAboutTask();
            }
            else
            {
                XmlDocument docproject = new XmlDocument();
                docproject.Load("project.xml");
                XmlNodeList projects = docproject.GetElementsByTagName("project");
                for (int i = 0; i < projects.Count; i++)
                {
                    XmlNodeList projectChilds = projects[i].ChildNodes;
                    if (projectChilds[2].InnerText == projectid)
                        Cb_SelectGroup.Text = projectChilds[0].InnerText;
                }
                XmlDocument docEmp = new XmlDocument();
                docEmp.Load("user.xml");
                XmlNodeList EmployeeList = docEmp.GetElementsByTagName("Employee");
                for (int i = 0; i < EmployeeList.Count; i++)
                {
                    XmlNodeList Empid = EmployeeList[i].ChildNodes;
                    if (Empid[3].InnerText == projectid)
                    {
                        Cb_SelectedEmployee.Items.Add(Empid[1].InnerText);
                    }
                }
                showRecivedEmployee();
            }
        }

        private void showInfAboutTask()
        {
            GR_GivenTasks.Rows.Clear();
            XmlDocument docTask = new XmlDocument();
            docTask.Load("project.xml");

            XmlNodeList projects = docTask.GetElementsByTagName("project");
            XmlDocument docEmployees = new XmlDocument();

            //first loop on all the projects 
            for (int i = 0; i < projects.Count; i++)
            {
                // project node
                XmlNodeList project = projects[i].ChildNodes;
                //main task node
                XmlNodeList Tasks = project[3].ChildNodes;

                for (int j = 0; j < Tasks.Count; j++)    //loop alltasks
                {
                    if (Tasks.Count != 0)
                    {
                        var index = GR_GivenTasks.Rows.Add();  //counter
                        GR_GivenTasks.Rows[index].Cells[0].Value = index + 1;  //get project name
                        GR_GivenTasks.Rows[index].Cells[7].Value = project[0].InnerText;
                        XmlNodeList InsideTaskNode = Tasks[j].ChildNodes; //all mini tasks inside main task

                        for (int k = 0; k < 5; k++)
                        {
                            GR_GivenTasks.Rows[index].Cells[k + 1].Value = InsideTaskNode[k].InnerText;
                        }
                        GR_GivenTasks.Rows[index].Cells[6].Value = InsideTaskNode[6].InnerText;
                    }
                }
            }
        }

        private void showRecivedEmployee()
        {
            GR_GivenTasks.Rows.Clear();
            XmlDocument docTask = new XmlDocument();
            docTask.Load("project.xml");
            XmlNodeList projectNamelist = docTask.GetElementsByTagName("Id");

            for (int i = 0; i < projectNamelist.Count; i++)
            {

                if (projectNamelist[i].InnerText == projectid)
                {
                    XmlNodeList tasks = projectNamelist[i].ParentNode.ChildNodes[3].ChildNodes;
                    for (int j = 0; j < tasks.Count; j++)
                    {
                        var index = GR_GivenTasks.Rows.Add();  //counter
                        GR_GivenTasks.Rows[index].Cells[0].Value = index + 1;  //get project name
                        GR_GivenTasks.Rows[index].Cells[7].Value = projectNamelist[i].ParentNode.ChildNodes[0].InnerText;
                        XmlNodeList InsideTaskNode = tasks[j].ChildNodes; //all mini tasks inside main task

                        for (int k = 0; k < 5; k++)
                        {
                            GR_GivenTasks.Rows[index].Cells[k + 1].Value = InsideTaskNode[k].InnerText;
                        }
                        GR_GivenTasks.Rows[index].Cells[6].Value = InsideTaskNode[6].InnerText;

                    }
                }
            }
        }
        private void AddNewTask()
        {

            if (txt_comm.Text != "" && txt_TaskDetails.Text != "" && txt_taskName.Text != "")
            {
                XmlDocument docTask = new XmlDocument();
                docTask.Load("project.xml");


                XmlNodeList pn = docTask.GetElementsByTagName("project");
                for (int i = 0; i < pn.Count; i++)
                {
                    XmlNodeList lp = pn[i].ChildNodes;
                    if (Cb_SelectGroup.Text.ToString() == lp[0].InnerText)
                    {
                        String id = lp[2].InnerText;
                        XmlElement taskkk = docTask.CreateElement("Task");

                        XmlElement node = docTask.CreateElement("TaskName");
                        node.InnerText = txt_taskName.Text;
                        taskkk.AppendChild(node);

                        node = docTask.CreateElement("employeeUserName");
                        node.InnerText = Cb_SelectedEmployee.Text;
                        taskkk.AppendChild(node);

                        node = docTask.CreateElement("Description");
                        node.InnerText = txt_TaskDetails.Text;
                        taskkk.AppendChild(node);

                        node = docTask.CreateElement("Comment");
                        node.InnerText = txt_comm.Text;
                        taskkk.AppendChild(node);


                        node = docTask.CreateElement("Status");



                        node.InnerText = "Available";
                        taskkk.AppendChild(node);

                        node = docTask.CreateElement("achievedFile");
                        node.InnerText = "";
                        taskkk.AppendChild(node);
                        node = docTask.CreateElement("History");
                        node.InnerText = DTP_History.Value.ToString();
                        taskkk.AppendChild(node);
                        node = docTask.CreateElement("id");
                        node.InnerText = id;
                        taskkk.AppendChild(node);
                        node = docTask.CreateElement("farward");
                        node.InnerText = "false";
                        taskkk.AppendChild(node);
                        XmlElement t = (XmlElement)lp[3];
                        t.AppendChild(taskkk);

                    }
                }

                docTask.Save("project.xml");
                MessageBox.Show("you add new task succ");
            }
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            AddNewTask();
            if (!editpressed)
            {

                GR_GivenTasks.Rows.Clear();
                showInfAboutTask();
            }
            else
            {
                GR_GivenTasks.Rows.Clear();
                showRecivedEmployee();
            }

            txt_comm.Text = "";
            txt_TaskDetails.Text = "";
            txt_taskName.Text = "";
            MessageBox.Show("You Add new Task succ");
        }

       
        private void GR_GivenTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            cellindex = e.RowIndex;
            selectedcolumn = e.ColumnIndex;
            if (selectedcolumn != 9)
            {
                if (GR_GivenTasks.Rows[cellindex].Cells[5].Value.ToString() == "Available")
                {
                    DataGridViewRow row = GR_GivenTasks.Rows[cellindex];
                    cells = row.Cells;

                    txt_taskName.Text = cells[1].Value.ToString();
                    selected = cells[2].Value.ToString();
                    Cb_SelectedEmployee.SelectedItem = cells[2].Value.ToString();
                    Cb_SelectedEmployee.Text="";
                    Cb_SelectedEmployee.SelectedText = selected;
                    txt_TaskDetails.Text = cells[3].Value.ToString();
                    txt_comm.Text = cells[4].Value.ToString();
                    DTP_History.Text = cells[6].Value.ToString();
                    Cb_SelectGroup.SelectedItem = cells[7].Value.ToString();
                    Btn_Edit.Visible = true;
                    if (selectedcolumn == 8)
                    {

                        thisEmplDownload = cells[2].Value.ToString();


                        thisEmpltask = cells[1].Value.ToString();

                        XmlDocument docTask = new XmlDocument();
                        docTask.Load("project.xml");

                        XmlNodeList taskslist = docTask.GetElementsByTagName("Task");


                        for (int i=0; i< taskslist.Count; i++)
                        {
                            XmlNodeList tt = taskslist[i].ChildNodes;

                            if (thisEmpltask == tt[0].InnerText)
                            {
                                if (tt[5].InnerText =="")
                                {
                                    MessageBox.Show("The Employee Doesn't Upload File Yet !!");
                                }
                                else
                                {
                                    Process.Start(tt[5].InnerText);
                                }
                            }
                        }



                    }
                }
                else if (GR_GivenTasks.Rows[cellindex].Cells[5].Value.ToString() == "Un Available")
                {
                    
                    Btn_Edit.Visible = false;
                }
                
            }

            else
            {
                MessageBox.Show(selectedcolumn.ToString());
                XmlDocument docTask = new XmlDocument();
                docTask.Load("project.xml");

                XmlNodeList pn = docTask.GetElementsByTagName("project");
                for (int i = 0; i < pn.Count; i++)
                {
                    XmlNodeList lp = pn[i].ChildNodes; // here list of each project
                    if (GR_GivenTasks.Rows[e.RowIndex].Cells[7].Value.ToString() == lp[0].InnerText)
                    {
                        XmlNodeList listtTask = lp[3].ChildNodes; // here list of tasks in the Selected project
                     
                        for (int j = 0; j < listtTask.Count; j++)
                        {

                            XmlNodeList task = listtTask[j].ChildNodes;
                            if (GR_GivenTasks.Rows[e.RowIndex].Cells[1].Value.ToString() == task[0].InnerText)
                            {
                                task[4].InnerText = "Un Available";

                                docTask.Save("project.xml");
                                break;
                            }


                        }
                    }
                    GR_GivenTasks.Rows[e.RowIndex].Cells[5].Value = "Un Available";
                }

            }
            selectedcolumn = 0;

        }

        private void Cb_SelectGroup_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string id = "";
            Cb_SelectedEmployee.Items.Clear();

            XmlDocument docproject = new XmlDocument();
            docproject.Load("project.xml");
            XmlNodeList projects = docproject.GetElementsByTagName("project");
            for (int i = 0; i < projects.Count; i++)
            {
                XmlNodeList projectChilds = projects[i].ChildNodes;
                if (projectChilds[0].InnerText == Cb_SelectGroup.Text.ToString())
                    id = projectChilds[2].InnerText;
            }

            XmlDocument docEmp = new XmlDocument();
            docEmp.Load("user.xml");
            XmlNodeList EmployeeList = docEmp.GetElementsByTagName("Employee");
            for (int i = 0; i < EmployeeList.Count; i++)
            {
                XmlNodeList Empid = EmployeeList[i].ChildNodes;
                if (Empid[3].InnerText == id)
                {
                    Cb_SelectedEmployee.Items.Add(Empid[1].InnerText);
                }
            }
        }

        private void btn_Submit_Click_1(object sender, EventArgs e)
        {
            
        }

        private void GR_GivenTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Edit_Click_1(object sender, EventArgs e)
        {
            
            if (txt_comm.Text != "" && txt_TaskDetails.Text != "" && txt_taskName.Text != "")

            {
                XmlDocument docTask = new XmlDocument();
                docTask.Load("project.xml");

                XmlNodeList pn = docTask.GetElementsByTagName("project");
                for (int i = 0; i < pn.Count; i++)
                {
                    XmlNodeList lp = pn[i].ChildNodes; // here list of each project
                    if (Cb_SelectGroup.Text == lp[0].InnerText)
                    {
                        XmlNodeList listtTask = lp[3].ChildNodes; // here list of tasks in the Selected project
                        for (int j = 0; j < listtTask.Count; j++)
                        {

                            XmlNodeList task = listtTask[j].ChildNodes;
                            if (cells[1].Value.ToString() == task[0].InnerText)
                            {
                             
                                task[0].InnerText = txt_taskName.Text;
                                task[2].InnerText = txt_TaskDetails.Text;
                                task[3].InnerText = txt_comm.Text;
                                docTask.Save("project.xml");
                                break;
                            }
                        }
                    }
                }
    
            }
            txt_comm.Text = "";
            txt_TaskDetails.Text = "";
            txt_taskName.Text = "";

            if (!editpressed)
            {

                GR_GivenTasks.Rows.Clear();
                showInfAboutTask();
            }
            else
            {
                GR_GivenTasks.Rows.Clear();
                showRecivedEmployee();
            }
            MessageBox.Show("Done!");

        }



    }
}
