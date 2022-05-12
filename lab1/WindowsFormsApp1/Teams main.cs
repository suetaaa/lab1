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
        internal static Team[] teams = new Team[5];

        //imgList
        String[] imgList = new String[]
            {"1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", "6.jpg", "7.jpg", "8.jpg", "9.jpg", "10.jpg", "11.jpg", "12.jpg", "13.jpg", "14.jpg", "15.jpg"};
        
        public Teams_main()
        {


            teams[0] = new Team();
            teams[0].setAll(1, "Miami Heat", "MIA", "1.jpg");

            teams[1] = new Team();
            teams[1].setAll(2, "Orlando Magic", "ORL", "2.jpg");

            teams[2] = new Team();
            teams[2].setAll(3, "Atlanta Hawks", "ATL", "3.jpg");

            teams[3] = new Team();
            teams[3].setAll(4, "Washington Wizards", "WSH", "4.jpg");

            teams[4] = new Team();
            teams[4].setAll(5, "Charlotte Hornets", "CHA", "5.jpg");
           

 

            InitializeComponent();

            for (int i = 0; i < 5; i++)
                Controls["rh"+(i+1)].Text = teams[i].name;

            for (int i = 0; i < 5; i++)
                Controls["rn"+(i+1)].Text = teams[i].name;

            for (int i = 0; i < 5; i++)
                Controls["r"+(i + 1)].Text = teams[i].name;

            Logo1.Load("../../../Teams/" + imgList[0]); Logo2.Load("../../../Teams/" + imgList[1]); Logo3.Load("../../../Teams/" + imgList[2]);
            Logo4.Load("../../../Teams/" + imgList[3]); Logo5.Load("../../../Teams/" + imgList[4]); Logo6.Load("../../../Teams/" + imgList[5]);
            Logo7.Load("../../../Teams/" + imgList[6]); Logo8.Load("../../../Teams/" + imgList[7]); Logo9.Load("../../../Teams/" + imgList[8]);
            Logo10.Load("../../../Teams/" + imgList[9]); Logo11.Load("../../../Teams/" + imgList[10]); Logo12.Load("../../../Teams/" + imgList[11]);
            Logo13.Load("../../../Teams/" + imgList[12]); Logo14.Load("../../../Teams/" + imgList[13]); Logo15.Load("../../../Teams/" + imgList[14]);
        }

        private void label35_Click(object sender, EventArgs e)
        {
            Team_Detail team = new Team_Detail();
            team.teamId = 1;
            team.Show();
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

        private void label27_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label43_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label46_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label49_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label52_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label37_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label44_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label47_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label50_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label53_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label39_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label45_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label48_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label51_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label54_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label55_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label58_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label61_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label64_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label38_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label56_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label59_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label62_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label65_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label40_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label57_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label60_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label63_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label66_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void rh2_Click(object sender, EventArgs e)
        {

            Team_Detail team = new Team_Detail();
            team.teamId = 1;
            team.Show();
        }

        private void rh3_Click(object sender, EventArgs e)
        {

            Team_Detail team = new Team_Detail();
            team.teamId = 1;
            team.Show();
        }

        private void rh4_Click(object sender, EventArgs e)
        {

            Team_Detail team = new Team_Detail();
            team.teamId = 1;
            team.Show();
        }

        private void rh5_Click(object sender, EventArgs e)
        {

            Team_Detail team = new Team_Detail();
            team.teamId = 1;
            team.Show();
        }

        private void rn1_Click(object sender, EventArgs e)
        {

            Team_Detail team = new Team_Detail();
            team.teamId = 1;
            team.Show();
        }

        private void rn2_Click(object sender, EventArgs e)
        {

            Team_Detail team = new Team_Detail();
            team.teamId = 1;
            team.Show();
        }

        private void rn3_Click(object sender, EventArgs e)
        {

            Team_Detail team = new Team_Detail();
            team.teamId = 1;
            team.Show();
        }

        private void rn4_Click(object sender, EventArgs e)
        {

            Team_Detail team = new Team_Detail();
            team.teamId = 1;
            team.Show();
        }

        private void rn5_Click(object sender, EventArgs e)
        {

            Team_Detail team = new Team_Detail();
            team.teamId = 1;
            team.Show();
        }

        private void r1_Click(object sender, EventArgs e)
        {

            Team_Detail team = new Team_Detail();
            team.teamId = 1;
            team.Show();
        }

        private void r2_Click(object sender, EventArgs e)
        {

            Team_Detail team = new Team_Detail();
            team.teamId = 1;
            team.Show();
        }

        private void r3_Click(object sender, EventArgs e)
        {

            Team_Detail team = new Team_Detail();
            team.teamId = 1;
            team.Show();
        }

        private void r4_Click(object sender, EventArgs e)
        {

            Team_Detail team = new Team_Detail();
            team.teamId = 1;
            team.Show();
        }

        private void r5_Click(object sender, EventArgs e)
        {

            Team_Detail team = new Team_Detail();
            team.teamId = 1;
            team.Show();
        }
    }
}
