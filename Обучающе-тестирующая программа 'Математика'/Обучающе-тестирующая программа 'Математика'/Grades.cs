using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Обучающе_тестирующая_программа__Математика_
{
    public partial class Grades : Form
    {
        public Grades()
        {
            InitializeComponent();
        }

        private void Grades1_Load(object sender, EventArgs e)
        {
            List<string> groups = WorkWithBD.getGroupNameList();
            cB_group.Items.AddRange(groups.ToArray());
            if (cB_group.Items.Count > 0)
            {
                cB_group.SelectedIndex = 0;
            }
            
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            string group = cB_group.SelectedItem.ToString();

            ReportParameter DateFromParam = new ReportParameter("ReportParameterGroup", group);
            reportViewerGrades.LocalReport.SetParameters(DateFromParam);

            this.reportViewerGrades.RefreshReport();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Обучающе-тестирующая программа 'Математика'", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Teacher_data(Data.userId).Show();
        }

        private void учебнаяПрограммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Curriculum().Show();
            this.Close();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Students().Show();
            this.Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
