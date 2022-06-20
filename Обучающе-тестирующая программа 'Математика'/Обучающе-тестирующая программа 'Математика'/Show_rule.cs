using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Обучающе_тестирующая_программа__Математика_
{
    public partial class Show_rule : Form
    {
        private int ruleId;

        public Show_rule()
        {
            InitializeComponent();
        }

        public Show_rule(int ruleId)
        {
            InitializeComponent();
            this.ruleId = ruleId;
        }

        private void Show_rule_Load(object sender, EventArgs e)
        {
            string[] ruleInfo = WorkWithBD.showRule(ruleId);
            lbl_ruleName.Text = ruleInfo[0];
            tB_ruleText.Text = ruleInfo[1];
        }

        private void tSB_back_Click(object sender, EventArgs e)
        {
            new Student_curriculum().Show();
            this.Close();
        }
    }
}
