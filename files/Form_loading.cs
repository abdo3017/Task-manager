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
    public partial class Form_loading : Form
    {
        int counter = 0;
        public Form_loading()
        {
            InitializeComponent();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            counter += 5;
            if (counter > 100)
            {
                counter = 100;
               
                this.Hide();

            }
            LoadingBar.Value = counter;
        }

        private void Form_loading_Load(object sender, EventArgs e)
        {
            LoadingTimer.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
