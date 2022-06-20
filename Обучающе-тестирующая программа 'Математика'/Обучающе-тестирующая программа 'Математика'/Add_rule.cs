using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Обучающе_тестирующая_программа__Математика_
{
    public partial class Add_rule : Form
    {
        private int themeId;
        private int ruleId = 0;

        public Add_rule()
        {
            InitializeComponent();
        }

        public Add_rule(int themeId)
        {
            InitializeComponent();
            this.themeId = themeId;
        }

        public Add_rule(int themeId, int ruleId)
        {
            InitializeComponent();
            this.themeId = themeId;
            this.ruleId = ruleId;
        }

        private void btn_choose_Click(object sender, EventArgs e)
        {
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string ruleName = tB_ruleName.Text;
            string ruleText = tB_ruleText.Text;

            if (!string.IsNullOrEmpty(ruleName) && !string.IsNullOrWhiteSpace(ruleName))
            {
                if (ruleId == 0)
                {
                    WorkWithBD.addRule(ruleName, ruleText, themeId);
                }

                if (ruleId != 0)
                {
                    WorkWithBD.changeRule(ruleName, ruleText, themeId);
                }
            }
            else
            {
                MessageBox.Show("Укажите название правила!");
            }

            new Curriculum().Show();
            this.Close();
        }

        private void Add_rule_Load(object sender, EventArgs e)
        {
            if (ruleId != 0)
            {
                string[] ruleInfo = WorkWithBD.showRule(ruleId);
                tB_ruleName.Text = ruleInfo[0];
                tB_ruleText.Text = ruleInfo[1];
            }
        }

        private void tSB_back_Click(object sender, EventArgs e)
        {
            new Curriculum().Show();
            this.Close();
        }
    }
}
