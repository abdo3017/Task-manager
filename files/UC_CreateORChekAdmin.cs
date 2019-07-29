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
	public partial class UC_CreateORChekAdmin : UserControl
	{
		public UC_CreateORChekAdmin()
		{
			InitializeComponent();
		}

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UC_CreateORChekAdmin_Load(object sender, EventArgs e)
        {
            XmlDocument docEmp = new XmlDocument();
            docEmp.Load("user.xml");
            XmlNodeList Admin = docEmp.GetElementsByTagName("Admin");
            for (int i = 0; i < Admin.Count; i++)
            {
                XmlNodeList Adminchilds = Admin[i].ChildNodes;
                var index = GR_AllAdmins.Rows.Add();
                for (int k = 0; k < Adminchilds.Count; k++)
                {

                    
                    GR_AllAdmins.Rows[index].Cells[k].Value = Adminchilds[k].InnerText;
                }
            }
        }

        private void GR_AllAdmins_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int cellindex = e.RowIndex;
            DataGridViewRow row = GR_AllAdmins.Rows[cellindex];
            DataGridViewCellCollection cells = row.Cells;
            txt_userName.Text = cells[0].Value.ToString();
            txt_name.Text = cells[1].Value.ToString();
            txt_pass.Text = cells[2].Value.ToString();

        }
    }
}
