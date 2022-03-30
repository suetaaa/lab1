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
    public partial class Teams_main : Form
    {
        Team[] teams = new Team[5];
        public Teams_main()
        {
            InitializeComponent();
            InitializeComponent();
            Team team = new Team();
            team.setTeamId(1);
            team.setName("Miami Heat");
            team.setAbbr("MIA");
            team.setLogo("1.jpg");
            teams[0] = team;

            team.setTeamId(2);
            team.setName("Orlando Magic");
            team.setAbbr("ORL");
            team.setLogo("2.jpg");
            teams[1] = team;

            team.setTeamId(3);
            team.setName("Atlanta Hawks");
            team.setAbbr("ATL");
            team.setLogo("3.jpg");
            teams[2] = team;

            team.setTeamId(4);
            team.setName("Washington Wizards");
            team.setAbbr("WSH");
            team.setLogo("4.jpg");
            teams[3] = team;

            team.setTeamId(5);
            team.setName("Charlotte Hornets");
            team.setAbbr("CHA");
            team.setLogo("5.jpg");
            teams[4] = team;
        }

        private void label35_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                this.Controls["label" + i].Text = teams[i].name;
        }

        private void label33_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label41_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label42_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form adminForm = new Visitor_Menu();
            adminForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form adminForm = new Teams_Main__2_();
            adminForm.Show();
        }
    }
}
