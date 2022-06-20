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
    public partial class Student_curriculum : Form
    {
        public Student_curriculum()
        {
            InitializeComponent();
        }

        private void Student_curriculum_Load(object sender, EventArgs e)
        {
            tV_Curriculum.Nodes.Clear();

            ImageList imageList = new ImageList();
            imageList.Images.Add(Properties.Resources.folder);
            imageList.Images.Add(Properties.Resources.book);
            imageList.Images.Add(Properties.Resources.pen);

            tV_Curriculum.ImageList = imageList;

            WorkWithBD.getCurriculum(tV_Curriculum, cMS_theme, cMS_rule, cMS_test);

            tV_Curriculum.ExpandAll();
            tV_Curriculum.HideSelection = true; //dont work
        }

        private void пройтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int testId = Convert.ToInt32(tV_Curriculum.SelectedNode.Tag);

            if (!WorkWithBD.checkThereIsGrade(testId))
            {
                new Test(testId).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы уже прошли данный тест!");
            }
        }

        private void оценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Student_grades().Show();
            this.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Обучающе-тестирующая программа 'Математика'", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ruleId = Convert.ToInt32(tV_Curriculum.SelectedNode.Tag);
            new Show_rule(ruleId).Show();
            this.Close();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Student_data(Data.userId).Show();
        }
    }
}
