using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Team_Detail_3 : Form
    {
        public Team_Detail_3()
        {
            InitializeComponent();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            Form adminForm = new Teams_main();
            adminForm.Show();
        }

        

       

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }
    }
}
