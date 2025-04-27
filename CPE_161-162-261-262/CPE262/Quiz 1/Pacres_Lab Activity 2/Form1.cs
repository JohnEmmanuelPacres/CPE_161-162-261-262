
using Pacres_Lab_Activity_2.Properties;

namespace Pacres_Lab_Activity_2
{
    public partial class MarketResearchSurvey : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        public MarketResearchSurvey()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }

        private void MarketResearchSurvey_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel.Add(panel4);
            listPanel.Add(panel5);
            listPanel.Add(panel6);
            listPanel.Add(panel7);
            listPanel.Add(panel8);
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }
        private void pb_str5_Click(object sender, EventArgs e)
        {
            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            pb_str3.Image = Resources.yellow_star;
            pb_str4.Image = Resources.yellow_star;
            pb_str5.Image = Resources.yellow_star;
        }

        private void pb_str4_Click(object sender, EventArgs e)
        {
            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            pb_str3.Image = Resources.yellow_star;
            pb_str4.Image = Resources.yellow_star;
            pb_str5.Image = Resources.white_star;
        }

        private void pb_str3_Click(object sender, EventArgs e)
        {
            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            pb_str3.Image = Resources.yellow_star;
            pb_str4.Image = Resources.white_star;
            pb_str5.Image = Resources.white_star;
        }

        private void pb_str2_Click(object sender, EventArgs e)
        {
            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.yellow_star;
            pb_str3.Image = Resources.white_star;
            pb_str4.Image = Resources.white_star;
            pb_str5.Image = Resources.white_star;
        }

        private void pb_str1_Click(object sender, EventArgs e)
        {
            pb_str1.Image = Resources.yellow_star;
            pb_str2.Image = Resources.white_star;
            pb_str3.Image = Resources.white_star;
            pb_str4.Image = Resources.white_star;
            pb_str5.Image = Resources.white_star;
        }

        private void ping5_Click(object sender, EventArgs e)
        {
            ping1.Image = Resources.yellow_star;
            ping2.Image = Resources.yellow_star;
            ping3.Image = Resources.yellow_star;
            ping4.Image = Resources.yellow_star;
            ping5.Image = Resources.yellow_star;
        }

        private void ping4_Click(object sender, EventArgs e)
        {
            ping1.Image = Resources.yellow_star;
            ping2.Image = Resources.yellow_star;
            ping3.Image = Resources.yellow_star;
            ping4.Image = Resources.yellow_star;
            ping5.Image = Resources.white_star;
        }

        private void ping3_Click(object sender, EventArgs e)
        {
            ping1.Image = Resources.yellow_star;
            ping2.Image = Resources.yellow_star;
            ping3.Image = Resources.yellow_star;
            ping4.Image = Resources.white_star;
            ping5.Image = Resources.white_star;
        }

        private void ping2_Click(object sender, EventArgs e)
        {
            ping1.Image = Resources.yellow_star;
            ping2.Image = Resources.yellow_star;
            ping3.Image = Resources.white_star;
            ping4.Image = Resources.white_star;
            ping5.Image = Resources.white_star;
        }

        private void ping1_Click(object sender, EventArgs e)
        {
            ping1.Image = Resources.yellow_star;
            ping2.Image = Resources.white_star;
            ping3.Image = Resources.white_star;
            ping4.Image = Resources.white_star;
            ping5.Image = Resources.white_star;
        }
        private void doom5_Click(object sender, EventArgs e)
        {
            doom1.Image = Resources.yellow_star;
            doom2.Image = Resources.yellow_star;
            doom3.Image = Resources.yellow_star;
            doom4.Image = Resources.yellow_star;
            doom5.Image = Resources.yellow_star;
        }
        private void doom4_Click(object sender, EventArgs e)
        {
            doom1.Image = Resources.yellow_star;
            doom2.Image = Resources.yellow_star;
            doom3.Image = Resources.yellow_star;
            doom4.Image = Resources.yellow_star;
            doom5.Image = Resources.white_star;
        }
        private void doom3_Click(object sender, EventArgs e)
        {
            doom1.Image = Resources.yellow_star;
            doom2.Image = Resources.yellow_star;
            doom3.Image = Resources.yellow_star;
            doom4.Image = Resources.white_star;
            doom5.Image = Resources.white_star;
        }
        private void doom2_Click(object sender, EventArgs e)
        {
            doom1.Image = Resources.yellow_star;
            doom2.Image = Resources.yellow_star;
            doom3.Image = Resources.white_star;
            doom4.Image = Resources.white_star;
            doom5.Image = Resources.white_star;
        }
        private void doom1_Click(object sender, EventArgs e)
        {
            doom1.Image = Resources.yellow_star;
            doom2.Image = Resources.white_star;
            doom3.Image = Resources.white_star;
            doom4.Image = Resources.white_star;
            doom5.Image = Resources.white_star;
        }

        private void xia5_Click(object sender, EventArgs e)
        {
            xia1.Image = Resources.yellow_star;
            xia2.Image = Resources.yellow_star;
            xia3.Image = Resources.yellow_star;
            xia4.Image = Resources.yellow_star;
            xia5.Image = Resources.yellow_star;
        }

        private void xia4_Click(object sender, EventArgs e)
        {
            xia1.Image = Resources.yellow_star;
            xia2.Image = Resources.yellow_star;
            xia3.Image = Resources.yellow_star;
            xia4.Image = Resources.yellow_star;
            xia5.Image = Resources.white_star;
        }

        private void xia3_Click(object sender, EventArgs e)
        {
            xia1.Image = Resources.yellow_star;
            xia2.Image = Resources.yellow_star;
            xia3.Image = Resources.yellow_star;
            xia4.Image = Resources.white_star;
            xia5.Image = Resources.white_star;
        }

        private void xia2_Click(object sender, EventArgs e)
        {
            xia1.Image = Resources.yellow_star;
            xia2.Image = Resources.yellow_star;
            xia3.Image = Resources.white_star;
            xia4.Image = Resources.white_star;
            xia5.Image = Resources.white_star;
        }

        private void xia1_Click(object sender, EventArgs e)
        {
            xia1.Image = Resources.yellow_star;
            xia2.Image = Resources.white_star;
            xia3.Image = Resources.white_star;
            xia4.Image = Resources.white_star;
            xia5.Image = Resources.white_star;
        }

        private void nigga5_Click(object sender, EventArgs e)
        {
            nigga1.Image = Resources.yellow_star;
            nigga2.Image = Resources.yellow_star;
            nigga3.Image = Resources.yellow_star;
            nigga4.Image = Resources.yellow_star;
            nigga5.Image = Resources.yellow_star;
        }

        private void nigga4_Click(object sender, EventArgs e)
        {
            nigga1.Image = Resources.yellow_star;
            nigga2.Image = Resources.yellow_star;
            nigga3.Image = Resources.yellow_star;
            nigga4.Image = Resources.yellow_star;
            nigga5.Image = Resources.white_star;
        }

        private void nigga3_Click(object sender, EventArgs e)
        {
            nigga1.Image = Resources.yellow_star;
            nigga2.Image = Resources.yellow_star;
            nigga3.Image = Resources.yellow_star;
            nigga4.Image = Resources.white_star;
            nigga5.Image = Resources.white_star;
        }

        private void nigga2_Click(object sender, EventArgs e)
        {
            nigga1.Image = Resources.yellow_star;
            nigga2.Image = Resources.yellow_star;
            nigga3.Image = Resources.white_star;
            nigga4.Image = Resources.white_star;
            nigga5.Image = Resources.white_star;
        }

        private void nigga1_Click(object sender, EventArgs e)
        {
            nigga1.Image = Resources.yellow_star;
            nigga2.Image = Resources.white_star;
            nigga3.Image = Resources.white_star;
            nigga4.Image = Resources.white_star;
            nigga5.Image = Resources.white_star;
        }

        private void pim5_Click(object sender, EventArgs e)
        {
            pim1.Image = Resources.yellow_star;
            pim2.Image = Resources.yellow_star;
            pim3.Image = Resources.yellow_star;
            pim4.Image = Resources.yellow_star;
            pim5.Image = Resources.yellow_star;
        }

        private void pim4_Click(object sender, EventArgs e)
        {
            pim1.Image = Resources.yellow_star;
            pim2.Image = Resources.yellow_star;
            pim3.Image = Resources.yellow_star;
            pim4.Image = Resources.yellow_star;
            pim5.Image = Resources.white_star;
        }

        private void pim3_Click(object sender, EventArgs e)
        {
            pim1.Image = Resources.yellow_star;
            pim2.Image = Resources.yellow_star;
            pim3.Image = Resources.yellow_star;
            pim4.Image = Resources.white_star;
            pim5.Image = Resources.white_star;
        }

        private void pim2_Click(object sender, EventArgs e)
        {
            pim1.Image = Resources.yellow_star;
            pim2.Image = Resources.yellow_star;
            pim3.Image = Resources.white_star;
            pim4.Image = Resources.white_star;
            pim5.Image = Resources.white_star;
        }

        private void pim1_Click(object sender, EventArgs e)
        {
            pim1.Image = Resources.yellow_star;
            pim2.Image = Resources.white_star;
            pim3.Image = Resources.white_star;
            pim4.Image = Resources.white_star;
            pim5.Image = Resources.white_star;
        }

        private void bb5_Click(object sender, EventArgs e)
        {
            bb1.Image = Resources.yellow_star;
            bb2.Image = Resources.yellow_star;
            bb3.Image = Resources.yellow_star;
            bb4.Image = Resources.yellow_star;
            bb5.Image = Resources.yellow_star;
        }

        private void bb4_Click(object sender, EventArgs e)
        {
            bb1.Image = Resources.yellow_star;
            bb2.Image = Resources.yellow_star;
            bb3.Image = Resources.yellow_star;
            bb4.Image = Resources.yellow_star;
            bb5.Image = Resources.white_star;
        }

        private void bb3_Click(object sender, EventArgs e)
        {
            bb1.Image = Resources.yellow_star;
            bb2.Image = Resources.yellow_star;
            bb3.Image = Resources.yellow_star;
            bb4.Image = Resources.white_star;
            bb5.Image = Resources.white_star;
        }

        private void bb2_Click(object sender, EventArgs e)
        {
            bb1.Image = Resources.yellow_star;
            bb2.Image = Resources.yellow_star;
            bb3.Image = Resources.white_star;
            bb4.Image = Resources.white_star;
            bb5.Image = Resources.white_star;
        }

        private void bb1_Click(object sender, EventArgs e)
        {
            bb1.Image = Resources.yellow_star;
            bb2.Image = Resources.white_star;
            bb3.Image = Resources.white_star;
            bb4.Image = Resources.white_star;
            bb5.Image = Resources.white_star;
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            string gender, age, marital, income, employ, educ, exer, sp;
            if (male_rBtn.Checked)
            {
                gender = male_rBtn.Text;
            }
            else if (female_rBtn.Checked)
            {
                gender = female_rBtn.Text;
            }
            else if (nonBinary_rBtn.Checked)
            {
                gender = nonBinary_rBtn.Text;
            }
            else
            {
                gender = pna_rBtn.Text;
            }

            if (ageRange1_rBtn.Checked)
            {
                age = ageRange1_rBtn.Text;
            }
            else if (ageRange2_rBtn.Checked)
            {
                age = ageRange2_rBtn.Text;
            }
            else if (ageRange3_rBtn.Checked)
            {
                age = ageRange3_rBtn.Text;
            }
            else if (ageRange4_rBtn.Checked)
            {
                age = ageRange4_rBtn.Text;
            }
            else if (ageRange5_rBtn.Checked)
            {
                age = ageRange5_rBtn.Text;
            }
            else if (ageRange6_rBtn.Checked)
            {
                age = ageRange6_rBtn.Text;
            }
            else
            {
                age = ageRange7_rBtn.Text;
            }
            if (single_rBtn.Checked)
            {
                marital = single_rBtn.Text;
            }
            else if (married_rBtn.Checked)
            {
                marital = married_rBtn.Text;
            }
            else if (widowed_rBtn.Checked)
            {
                marital = widowed_rBtn.Text;
            }
            else if (divorced_rBtn.Checked)
            {
                marital = divorced_rBtn.Text;
            }
            else
            {
                marital = pnaMarital_rBtn.Text;
            }

            if (income1.Checked)
            {
                income = income1.Text;
            }
            else if (income2.Checked)
            {
                income = income2.Text;
            }
            else if(income3.Checked)
            {
                income = income3.Text;
            }
            else if (income4.Checked)
            {
                income = income4.Text;
            }
            else if (income5.Checked)
            {
                income = income5.Text;
            }
            else if (income6.Checked)
            {
                income = income6.Text;
            }
            else
            {
                income = pna_income.Text;
            }

            if (employ1.Checked)
            {
                employ = employ1.Text;
            }
            else if(employ2.Checked)
            {
                employ = employ2.Text;
            }
            else if (employ3.Checked)
            {
                employ = employ3.Text;
            }
            else if (employ4.Checked)
            {
                employ = employ4.Text;
            }
            else if (employ5.Checked)
            {
                employ = employ5.Text;
            }
            else if (employ6.Checked)
            {
                employ = employ6.Text;
            }
            else if (employ7.Checked)
            {
                employ = employ7.Text;
            }
            else
            {
                employ = pna_employ.Text;
            }

            if (educ1.Checked)
            {
                educ = educ1 .Text;
            }
            else if (educ2.Checked)
            {
                educ = educ2.Text;
            }
            else if (educ3.Checked)
            {
                educ = educ3.Text;
            }
            else if (educ4.Checked)
            {
                educ = educ4.Text;
            }
            else if (educ6.Checked)
            {
                educ = educ6.Text;
            }
            else if (educ7.Checked)
            {
                educ = educ7.Text;
            }
            else
            {
                educ = pna_educ.Text;
            }
            if(a1.Checked)
            {
                exer = "Not all often";
            }
            else if(a10.Checked)
            {
                exer = "Extremely often";
            }
            else
            {
                exer = "Often";
            }
            if (b1.Checked)
            {
                sp = "Not all often";
            }
            else if (b10.Checked)
            {
                sp = "Extremely often";
            }
            else
            {
                sp = "Often";
            }

            MessageBox.Show("Successfully submitted!" + Environment.NewLine + 
                Environment.NewLine + "Responder's Details Summary:" +
                Environment.NewLine + "Gender: " + gender +
                Environment.NewLine + "Age range: " + age +
                Environment.NewLine + "Marital status: " + marital +
                Environment.NewLine + "Annual income range: " + income +
                Environment.NewLine + "Employment status: " + employ +
                Environment.NewLine + "Highest level of education: " + educ +
                Environment.NewLine + "Exercise frequency: " + exer +
                Environment.NewLine + "Sportswear frequency: " + sp +
                Environment.NewLine + Environment.NewLine + 
                "Note: Other information are hidden for the sake of privacy. Thank you for cooperation.");
        }
    }
}